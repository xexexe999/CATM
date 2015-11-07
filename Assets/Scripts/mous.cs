using UnityEngine;
using System.Collections;

public class mous : MonoBehaviour {
	
	public Transform cat;
	public Rigidbody Mousee;
	public AudioSource trt;

	void Start(){

	}
	
	void FixedUpdate () {
		
		Vector3 directionToCat = cat.transform.position - transform.position;
		float angle = Vector3.Angle (directionToCat, transform.forward);  
		
		if (angle < 180f) {
			Ray mouseRay = new Ray (transform.position, directionToCat);
			RaycastHit mouseRayHitInfo = new RaycastHit ();
			
			if (Physics.Raycast (mouseRay, out mouseRayHitInfo, 10f)) {
				Debug.DrawRay (mouseRay.origin, mouseRay.direction, Color.yellow);
				
				if (mouseRayHitInfo.collider.tag == "Cat") {
					Mousee.AddForce (-directionToCat.normalized * 8000f);}
				trt.Play();
				trt.pitch = Random.Range(0.15f,1.75f);
				trt.volume = Random.Range(0.45f,0.8f);


				}
			}
	
	}
	}	

