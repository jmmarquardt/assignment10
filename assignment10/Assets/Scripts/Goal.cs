using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour 
{

	public Text text;

	// Use this for initialization
	void Start () 
	{
		// get the GUI text box
		// text = GetComponent<Text>();
		// transparent canvas text color
		text.color = new Color(0, 0, 0, 0);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) 
	{
		text.color = new Color(1, 1, 0, 1);
	}

	void OnTriggerExit()
	{
		text.color = new Color(0, 0, 0, 0);
	}
}
