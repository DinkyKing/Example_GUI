using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // This is important for UI obviously


// We access this script with the buttons onclick function in the inspector

public class ButtonScript : MonoBehaviour {

	private int num = 0;
	public string clicked = "Well Done"; // String to be displayed
	private string initalText; //Lets store the original

	// Use this for initialization
	void Start () {
		initalText = this.gameObject.GetComponentInChildren<Text>().text; // Store the original from the text which is a child of the button.
	}

	public void Click(){ // Use the function of the button
		this.gameObject.GetComponentInChildren<Text>().text = clicked + " " + num; // Access the child and change it
		num++;
		if (num >= 10) {
			this.gameObject.GetComponentInChildren<Text> ().text = "Alright you can stop now";
		}
	}
}
