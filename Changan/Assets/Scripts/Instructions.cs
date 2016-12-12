using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour {

	public void ShowInstructions(){
		NGUITools.SetActive (this.gameObject, true);
	}

	public void HideInstructions(){
		NGUITools.SetActive (this.gameObject, false);
	}

}
