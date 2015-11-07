using UnityEngine;
using System.Collections;

public class CAT : MonoBehaviour {
	
	public Transform moew;
	public Rigidbody cat;
	public AudioSource eat;	

	
	void FixedUpdate () {
		
		Vector3 directionToMouse = moew.transform.position - transform.position;
		float angle = Vector3.Angle (directionToMouse, transform.forward);  
		
		if (angle < 90f) {
			Ray catRay = new Ray (transform.position, directionToMouse);
			RaycastHit catRayHitInfo = new RaycastHit ();
			
			if (Physics.Raycast (catRay, out catRayHitInfo, 10f)) {
				Debug.DrawRay (catRay.origin, catRay.direction, Color.red);
				
				if (catRayHitInfo.collider.tag == "Mouse") {
					if (catRayHitInfo.distance < 3f) {
						Destroy (moew.gameObject);
						eat.Play ();
					
					} else {
						cat.AddForce (directionToMouse.normalized * 3000f);
					
					}
				}
			}
		}
	}	
}

