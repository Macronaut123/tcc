using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class NpcSystemTalk : MonoBehaviour
{
    private string[] currentConversa;
    private string[] conversa_0;
    public bool talking;
    public int currentLine;
    public string _talking;
    public bool camDesactive = false;
    public bool Disenable;
    public float globaTime;

    void Start()
    {
        currentLine = 1;
    }

    public void getTalkForThisAction(string[] temp)
    {
        this.conversa_0 = temp;
    }

    void OnTriggerEnter(Collider hit)
    {

        if (hit.tag == "Player")
        {
            if (camDesactive)
            {
                GameObject.Find("MiniMap").camera.enabled = false;
            }
            currentLine = 1;
            talking = true;
            _talking = GetingTalk()[currentLine];
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
            talking = false;
            currentLine = 1;
            _talking = "";
            GameObject.Find("globalTime").GetComponent<GlobalTime>().disable = true;
        }
    }

    public List<string> GetingTalk()
    {

        globaTime = GameObject.Find("globalTime").GetComponent<GlobalTime>().globalTimer;
        string[] checkConversa_0 = conversa_0[0].Split('/');
        List<string> temp = new List<string>();

        if (float.Parse(checkConversa_0[0]) <= (int)globaTime && float.Parse(checkConversa_0[1]) >= globaTime)
        {
            temp.AddRange(conversa_0);
        }
        else
        {
            temp.Add("other action here ->");
        } 
        return temp;
    }

    void Update()
    {
        if (talking)
        {
            if (Input.GetKeyDown(KeyCode.PageDown))
            {
                if (currentLine < GetingTalk().Capacity - 1)
                {
                    currentLine++;
                    _talking = GetingTalk()[currentLine];
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
                    _talking = "";
                    talking = false;
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
