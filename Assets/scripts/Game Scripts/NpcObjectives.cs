using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NpcObjectives : MonoBehaviour
{
	public Dictionary<string ,bool> dependencyActions;

    public void Awake()
    {
        dependencyActions = new Dictionary<string, bool>();

        switch (gameObject.name)
        {
			case "Player":
                dependencyActions.Add("letter_condition", false);
				dependencyActions.Add("knowgunvar_condition", false);
				dependencyActions.Add("knowriki_condition", false);
				dependencyActions.Add("colar_condition", false);
			
				//FINAL
				dependencyActions.Add("FINAL_DEFAULT", false);
				dependencyActions.Add("FINAL_BAD", false);
				dependencyActions.Add("FINAL_GOOD", false);
				dependencyActions.Add("FINAL_PERFECT", false);
			
            break;
			
            case "NPC_Aina":

                dependencyActions.Add("player_knowledge_to_got_churchkey", false);
                dependencyActions.Add("player_got_churchkey", false);
            break;

            case "NPC_Alviss":
                dependencyActions.Add("player_knowledge_to_got_churchkey", false);
                dependencyActions.Add("player_got_churchkey_definity", false);
				dependencyActions.Add("player_got_churchkey", false);
            break;
        }
    }
}