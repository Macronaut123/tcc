using UnityEngine;
using System.Collections;

public class SetObjectives : GenericFunction {

    public void OnTriggerEnter(Collider hit)
    {
        switch (hit.gameObject.name)
        {

            case "NPC_Aina":


                if (getDependency(hit.gameObject, "player_knowledge_to_got_churchkey", true))
                {
                    setDependency(hit.gameObject, "player_got_churchkey", true);
                }
                else
                {
                }

            break;

            case "NPC_Alviss":

                if (getDependency(hit.gameObject, "player_knowledge_to_got_churchkey", false))
                {
                    setDependency(hit.gameObject, "player_knowledge_to_got_churchkey", true);
                }

                else if (getDependency(hit.gameObject, "player_got_churchkey", false))
                {
                    setDependency(hit.gameObject, "player_got_churchkey_definity", true);
                }
   
            break;
        }
    }
}
