using UnityEngine;
using System.Collections;

public class raycastpaint : MonoBehaviour {
	public Transform redsphere;
	void Update () {
		//be4 firing raycast, generate a ray for it
		Ray mOUsEray = Camera.main.ScreenPointToRay (Input.mousePosition);
		//and then raycasthit to store hit info--- where it hit, what it hit, angle?
		RaycastHit mouseRayHit= new RaycastHit();
		//put in iff cos if raycast is unsuccessful theres no point in the data
		if ((Physics.Raycast(mOUsEray, out mouseRayHit, 1000f)) && Input.GetMouseButton(0)){
	//INSTANTIATE a ray sphere 
		Instantiate(redsphere,mouseRayHit.point,Quaternion.identity); 
		}
	
	}
public void ToggleColor (){
		redsphere.GetComponent<Renderer>().material.color = Color.cyan;


	}


}
