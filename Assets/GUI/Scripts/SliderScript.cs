using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {

	private Slider theSlider;
	public GameObject anObject;

	void Start(){
		theSlider = gameObject.GetComponent<Slider> ();
	}

	public void slideColor(){
		if (theSlider.value == 1) {
			Instantiate (anObject);
		}
	}
}
