using UnityEngine;
using System.Collections;

public class NightFixSlot : MonoBehaviour {

	public GameObject nightSlot1;
	public GameObject night1;
	public GameObject night2;
	public GameObject night3;
	public GameObject night4;
	public GameObject night5;
	public GameObject night6;
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
		if (TimeRotate.DayOrNight == 2&&temp) {
			temp=true;
			RefreshNightFix();
			temp=false;
		}
		
	}
	
	public void RefreshNightFix(){
		for(int i = 0;i<nightSlot1.transform.childCount;i++)
		{
			GameObject go = nightSlot1.transform.GetChild(i).gameObject;
			Destroy(go);
		}
		sceneName = Application.loadedLevelName;
		switch(sceneName){
		case "city":
			GameObject go1 = NGUITools.AddChild (nightSlot1, night1);
			go1.transform.localPosition = Vector3.zero;
			break;
		case "forest":
			GameObject go2 = NGUITools.AddChild (nightSlot1, night2);
			go2.transform.localPosition = Vector3.zero;
			break;
		case "home":
			GameObject go3 = NGUITools.AddChild (nightSlot1, night3);
			go3.transform.localPosition = Vector3.zero;
			break;
		case "village":
			GameObject go4 = NGUITools.AddChild (nightSlot1, night4);
			go4.transform.localPosition = Vector3.zero;
			break;
		case "store":
			GameObject go5 = NGUITools.AddChild (nightSlot1, night5);
			go5.transform.localPosition = Vector3.zero;
			break;
		case "hotel":
			GameObject go6 = NGUITools.AddChild (nightSlot1, night6);
			go6.transform.localPosition = Vector3.zero;
			break;
		}
	}
}