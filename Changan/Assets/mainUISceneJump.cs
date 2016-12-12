using UnityEngine;
using System.Collections;

public class mainUISceneJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoBackpack(){
		if (Application.loadedLevelName != "backPack") {
			Application.LoadLevel (1);
		}
	}

	public void GoBigMap(){
		if (Application.loadedLevelName != "BigMap") {
			Application.LoadLevel (0);
		}
	}

    public void GoMission(){
		if (Application.loadedLevelName != "MissionSystem") {
		Application.LoadLevel (2);
        }
	}
}

