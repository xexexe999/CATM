using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
	
	public static List<GameObject> catList = new List<GameObject>();
	public static List<GameObject> mouseList = new List<GameObject>();
	
	public GameObject catPrefab;
	public GameObject mousePrefab;

	
	void Update(){
	
		if (Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit rayHit = new RaycastHit ();
			
			if (Physics.Raycast (ray, out rayHit)) {
				if (rayHit.collider.tag == "Floor") {
					GameObject newCat = (GameObject)Instantiate (catPrefab, new Vector3( rayHit.point.x, 1f, rayHit.point.z), Quaternion.identity);
					catList.Add (newCat);
				}	
			}
		} else if (Input.GetMouseButtonDown(1)){
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit rayHit = new RaycastHit ();
			
			if (Physics.Raycast (ray, out rayHit)) {
				if (rayHit.collider.tag == "Floor") {
					GameObject newMouse = (GameObject)Instantiate (mousePrefab, new Vector3( rayHit.point.x, 1f, rayHit.point.z), Quaternion.identity);
					mouseList.Add (newMouse);
				}	
			}
		}
	}
}

