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