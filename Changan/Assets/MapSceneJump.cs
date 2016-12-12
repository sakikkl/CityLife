using UnityEngine;
using System.Collections;

public class MapSceneJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void MapJump(){
		Application.LoadLevel (3);
		control_talk.talkID = 2;
	}
	public void GoCity(){
		Application.LoadLevel (4);
}
}
