using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour {
		
	private string words = "I have been defeated";

	public void ClickToWin(){
		this.gameObject.GetComponentInChildren<Text> ().text = words;
	}
}
