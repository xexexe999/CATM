using UnityEngine;
using System.Collections;

public class ballrobot : MonoBehaviour {

	// Use this for initialization

	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * Time.deltaTime *9f;
		// exactly bfsame as transform.Translate (0f,0f,5f * Time.deltaTime *5f);
		Ray ray = new Ray(transform.position, transform.forward); 
	if (Physics.Raycast (ray, 1.5f)){
			transform.Rotate (0f,(Random.Range(-70,-100)),0f);
		
		}
	
	}
}
