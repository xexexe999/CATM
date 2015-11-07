using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ForestGen : MonoBehaviour {

	public GameObject treePrefab;//gotta be called prefab or else ptm
	List<GameObject> listofTrees = new List<GameObject>();
	// Use this for initialization
	void Start () {

		while (listofTrees.Count < 47){
			GameObject newTree = (GameObject)Instantiate (treePrefab, new Vector3(Random.Range(-10,10), 3, Random.Range (-10,10)), Quaternion.Euler(0,0,0));
			listofTrees.Add (newTree);

		}
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.UpArrow))
			for (int x=0; x<listofTrees.Count; x++){
			listofTrees[x].transform.localScale *= Random.Range (1.1f,1.5f);
	}

		Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit mouseRayHit = new RaycastHit();
		if (Input.GetMouseButtonDown (0)){
			if (Physics.Raycast (mouseRay, out mouseRayHit,100f)){
				GameObject newTree = (GameObject)Instantiate (treePrefab, new Vector3 (mouseRayHit.point.x, 3f, mouseRayHit.point.z), Quaternion.identity);
				listofTrees.Add (newTree);
				//OR CAN ALSO USE mouseRayHit.point + new Vector 3 (0f,2f,0f)etc

			}
	}
	if (Input.GetMouseButtonDown(1)){
			if (Physics.Raycast (mouseRay, out mouseRayHit,100f)){
				GameObject thingclickedOn = mouseRayHit.transform.gameObject;
				if (listofTrees.Contains (thingclickedOn)){
					listofTrees.Remove (thingclickedOn);
					Destroy (thingclickedOn);
				}
		}
	}
	}}