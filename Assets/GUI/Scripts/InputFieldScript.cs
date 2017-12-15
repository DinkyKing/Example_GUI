using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldScript : MonoBehaviour {

	public Text heroesName;
	public Text theWriting;

	public void HeroName(){
		heroesName.text = theWriting.text;
	}
}
