using UnityEngine;
using System.Collections;

public class DayFixSlot : MonoBehaviour {
	public GameObject daySlot1;
	public GameObject day1;
	public GameObject day2;
	public GameObject day3;
	public GameObject day4;
	public GameObject day5;
	public GameObject day6;
	private bool temp;
	private string sceneName;
	// Use this for initialization
	void Awake(){
		temp=true;
	}
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (TimeRotate.DayOrNight == 1&&temp) {
			temp=true;
			RefreshDayFix();
			temp=false;
		}
	
	}

	public void RefreshDayFix(){
		for(int i = 0;i<daySlot1.transform.childCount;i++)
		{
			GameObject go = daySlot1.transform.GetChild(i).gameObject;
			Destroy(go);
		}
		sceneName = Application.loadedLevelName;
		switch(sceneName){
		case "city":
			GameObject go1 = NGUITools.AddChild (daySlot1, day1);
			go1.transform.localPosition = Vector3.zero;
			break;
		case "forest":
			GameObject go2 = NGUITools.AddChild (daySlot1, day2);
			go2.transform.localPosition = Vector3.zero;
			break;
		case "home":
			GameObject go3 = NGUITools.AddChild (daySlot1, day3);
			go3.transform.localPosition = Vector3.zero;
			break;
		case "village":
			GameObject go4 = NGUITools.AddChild (daySlot1, day4);
			go4.transform.localPosition = Vector3.zero;
			break;
		case "store":
			GameObject go5 = NGUITools.AddChild (daySlot1, day5);
			go5.transform.localPosition = Vector3.zero;
			break;
		case "hotel":
			GameObject go6 = NGUITools.AddChild (daySlot1, day6);
			go6.transform.localPosition = Vector3.zero;
			break;
		}
}
}