using UnityEngine;
using System.Collections;

public class TimeName : MonoBehaviour {
	public UILabel TimeLabel;
	// Use this for initialization
	void Start () {
		TimeLabel = GetComponent<UILabel>();
	}
	
	// Update is called once per frame
	void Update () {
		if (TimeRotate.GetTime == 14.0) {
			TimeLabel.text="子时";
		}
	}
}
