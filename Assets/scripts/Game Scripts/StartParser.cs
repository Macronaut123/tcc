using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using UnityEngine;

public class StartParser : MonoBehaviour {

	public void Start()
	{
        Parser parser = new Parser();

        parser.LoadSpeeches(XDocument.Load("speeches.xml"));
        parser.LoadNpcs(XDocument.Load("npcs.xml"));

        print(parser.GetSpeech(parser.Npcs[0]).Text);
        print(parser.GetSpeech(parser.Npcs[1]).Text);
       	print(parser.GetSpeech(parser.Npcs[0]).Text);
	}
}
