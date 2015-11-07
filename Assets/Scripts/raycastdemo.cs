using UnityEngine;
using System.Collections;

public class raycastdemo : MonoBehaviour {
	public Transform sphere; 
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		//generate a 
		RaycastHit rayHit = new RaycastHit();

			// physics.RaycastAll instead if you want it to not stop! and raycast thru stuff.

		if (Physics.Raycast(ray, out rayHit, 300f)){
			Debug.Log ("you are p");
			Debug.DrawRay (ray.origin, ray.direction * rayHit.distance, Color.yellow); 
			if (Input.GetMouseButtonDown (1)){
			    sphere.position = rayHit.point; // if it flies towards cam, its cos its colliding w it too, so turn off collider or ignoreraycast
				sphere.up = rayHit.normal;
				//USE RESOURCES, FACILITIES, TALK TO PEOPLE, GO TO *********************************************
			}}
		//more efficient to wrap all in GETMOUSEBUTTON, SO WHEN CLICK RAYCAST EXISTS WHICH IS WHEN ITS NEEDED ANYW


	}
}
