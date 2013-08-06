using UnityEngine;
using System.Collections;

public class LevelManagerScript : MonoBehaviour {
	
	public GUIText talkTextGUI;
	public int edgeMarginPercentage;
	private int edgeMargin;
	
	// Use this for initialization
	void Start () {
		edgeMargin = (Screen.width/100) * edgeMarginPercentage;
		
		//Modo em c#
		talkTextGUI.pixelOffset = new Vector2(edgeMargin,edgeMargin);
	}
}
