using UnityEngine;
using System.Collections;

public class addMisson : MonoBehaviour {
	public GameObject[] grid;
	public GameObject cell;
	static public int storyID;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (storyID==1) {
			AddNewMission ();
			storyID=0;
		}
	}
	public void AddNewMission(){

		for (int i=0; i<grid.Length; i++) {
			if (grid[i].transform.childCount == 0) {
				GameObject go = NGUITools.AddChild (grid[i], cell);
				go.transform.localPosition = Vector3.zero;
				break;
				
			}
	}
}
}
