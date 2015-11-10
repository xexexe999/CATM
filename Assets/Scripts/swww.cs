using UnityEngine;
using System.Collections;

public class swww : MonoBehaviour {
	
		
		public GameObject treePrefab;
		float spawn_range = 22f;
		int max_trees = 10;
		
		// Use this for initialization
		void Start () {
			int treeCount = 0;
			while (treeCount < max_trees) {
				Instantiate(treePrefab, new Vector3(Random.Range(-spawn_range, spawn_range),1f, Random.Range(-spawn_range, spawn_range)), Quaternion.Euler(0, Random.Range(0f,180f),0));
				treeCount++;
			}
		}
	}