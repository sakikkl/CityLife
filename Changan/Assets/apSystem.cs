using UnityEngine;
using System.Collections;

public class apSystem : MonoBehaviour {

	public UIProgressBar progressBar1;
	public UILabel currentAP;
	private int Num=100;
	private int timeAdd;
	// Use this for initialization
	void Start () {
		progressBar1.value = 1;
		currentAP.text = "100";
	}
	
	// Update is called once per frame
	void Update () {
		if (System.DateTime.Now.Second == 30 & Num < 100) {
			Num+=1;
		}
		
	}
	public void BarValueReduce(){
		if (Num >= 5) {
			progressBar1.value -= 0.05f;
			Num -= 5;
			currentAP.text = Num + "";
		}
	}
}


