using UnityEngine;
using System.Collections;

public class spherebutton : MonoBehaviour {

//MEANS THAT PLAYER CLICKED ON THE COLLIDER AND RELEASED THE MOUSEBUTTON WHILE CURSOR WAS STILL OVER COLLIDER
	void OnMouseUpAsButton () {
		transform.localScale *= 1.1f;//multiply with every click
		transform.localPosition += new Vector3 (0.3f,0.3f,0.3f);
	}
}
