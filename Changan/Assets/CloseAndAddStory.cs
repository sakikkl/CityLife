using UnityEngine;
using System.Collections;

public class CloseAndAddStory : MonoBehaviour {
	public GameObject tips;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void closeAndAdd(){
	
		Destroy (tips);
		addMisson.storyID = 1;
	}
}
