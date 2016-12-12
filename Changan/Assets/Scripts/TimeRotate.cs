using UnityEngine;
using System.Collections;

public class TimeRotate : MonoBehaviour {
	static public float GetTime;
	//static public float MinuteTime;
	//static public float SecondGetTime;
	private float TargetAngel;
	private Transform TimePointer;
	static public int DayOrNight;

	// Use this for initialization
	void Start () {
		TimePointer = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		GetTime = System.DateTime.Now.Hour;
		TargetAngel = GetTime * 15.0f;
		TimePointer.rotation = Quaternion.AngleAxis(TargetAngel,Vector3.forward);
		if(GetTime==8|GetTime==9|GetTime==10|GetTime==11|GetTime==12|GetTime==13|GetTime==14|GetTime==15|GetTime==16|GetTime==17|GetTime==18){
			DayOrNight=1;}
		else{DayOrNight=2;}
		//Debug.Log (DayOrNight);
	}
}
