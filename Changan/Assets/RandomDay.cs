using UnityEngine;
using System.Collections;

public class RandomDay : MonoBehaviour {
	public GameObject daySlot1;
	public GameObject day1;
	public GameObject day2;
	public GameObject day3;
	public GameObject day4;
	public GameObject day5;
	public GameObject day6;
	private bool temp;
	private int dayRandomValue;
	// Use this for initialization
	void Awake(){
		temp=true;
	}
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (TimeRotate.GetTime == 11&&temp) {
			temp=true;
			RefreshNPC();
			temp=false;
		}
	}
	public void RefreshNPC(){
		for(int i = 0;i<daySlot1.transform.childCount;i++)
		{
			GameObject go = daySlot1.transform.GetChild(i).gameObject;
			Destroy(go);
		}
		dayRandomValue = Random.Range (1, 7);
		switch(dayRandomValue){
		case 1:
			GameObject go1 = NGUITools.AddChild (daySlot1, day1);
			go1.transform.localPosition = Vector3.zero;
			break;
		case 2:
			GameObject go2 = NGUITools.AddChild (daySlot1, day2);
			go2.transform.localPosition = Vector3.zero;
			break;
		case 3:
			GameObject go3 = NGUITools.AddChild (daySlot1, day3);
			go3.transform.localPosition = Vector3.zero;
			break;
		case 4:
			GameObject go4 = NGUITools.AddChild (daySlot1, day4);
			go4.transform.localPosition = Vector3.zero;
			break;
		case 5:
			GameObject go5 = NGUITools.AddChild (daySlot1, day5);
			go5.transform.localPosition = Vector3.zero;
			break;
		case 6:
			GameObject go6 = NGUITools.AddChild (daySlot1, day6);
			go6.transform.localPosition = Vector3.zero;
			break;
		}


	}
}
