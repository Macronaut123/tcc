/*using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class NpcSystemTalkTwoActions : MonoBehaviour
{

    public List<string> currentConversa;
    public string[] conversa_0;
    public string[] conversa_1;

    public bool isTalking = false;
    public string talking;
    public int currentLine;
    public bool camDesactive = false;
    public bool disable;
    public float globaTime;

    public bool firstAction = true;
    public bool secondAction = false;

    void Start()
    {
        currentLine = 1;
    }

    void OnTriggerEnter(Collider hit)
    {

        if (hit.tag == "Player")
        {
            currentConversa = new List<string>();

            if (camDesactive)
            {
                GameObject.Find("MiniMap").camera.enabled = false;
            }
            currentLine = 1;
            isTalking = true;
            currentConversa = GetingTalk();
            talking = currentConversa[currentLine];
            GameObject.Find("globalTime").GetComponent<GlobalTime>().disable = false;
        }
    }

    void OnTriggerExit(Collider hit)
    {
        if (hit.tag == "Player")
        {
            if (camDesactive)
            {
                GameObject.Find("globalTime").GetComponent<GlobalTime>().disable = true;
            }
            isTalking = false;
            currentLine = 1;
            talking = "";
            GameObject.Find("globalTime").GetComponent<GlobalTime>().disable = true;
        }
    }

    public List<string> GetingTalk()
    {

        globaTime = GameObject.Find("globalTime").GetComponent<GlobalTime>().globalTimer;
        List<string> temp = new List<string>();
        string[] checkConversa_0 = null;

        if (firstAction && !secondAction)
        {
            checkConversa_0 = conversa_0[0].Split('/');

            if (float.Parse(checkConversa_0[0]) <= (int)globaTime && float.Parse(checkConversa_0[1]) >= globaTime)
            {
                temp.AddRange(conversa_0);
            }
            else
            {
                temp.Add("other action here ->");
            }
        }

        if (firstAction && secondAction)
        {
            checkConversa_0 = conversa_1[0].Split('/');

            if (float.Parse(checkConversa_0[0]) <= (int)globaTime && float.Parse(checkConversa_0[1]) >= globaTime)
            {
                temp.AddRange(conversa_1);
            }
            else
            {
                temp.Add("other action here ->");
            }
        }
        return temp;
    }

    void Update()
    {
        if (isTalking)
        {
            if (Input.GetKeyDown(KeyCode.PageDown))
            {
                if (currentLine < currentConversa.Capacity - 1)
                {
                    currentLine++;
                    talking = currentConversa[currentLine];
                    GameObject.Find("globalTime").GetComponent<GlobalTime>().disable = false;
                    switch (gameObject.name)
                    {
                        case "NPC_armazem":
                            NpcTest.Armazem = true;
                         break;
                    }
                }
                else
                {
                    currentLine = 1;
                    talking = "";
                    isTalking = false;
                    GameObject.Find("globalTime").GetComponent<GlobalTime>().disable = true;
                    if (camDesactive)
                    {
                        GameObject.Find("MiniMap").camera.enabled = true;
                    }
                }
            }
        }
    }
}
*/