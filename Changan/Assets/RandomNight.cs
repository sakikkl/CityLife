using UnityEngine;
using System.Collections;

public class RandomNight : MonoBehaviour {

	public GameObject slot1;
	public GameObject sc1;
	public GameObject sc2;
	public GameObject sc3;
	public GameObject sc4;
	public GameObject sc5;
	public GameObject sc6;
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
		for(int i = 0;i<slot1.transform.childCount;i++)
		{
			GameObject go = slot1.transform.GetChild(i).gameObject;
			Destroy(go);
		}
		dayRandomValue = Random.Range (1, 7);
		switch(dayRandomValue){
		case 1:
			GameObject go1 = NGUITools.AddChild (slot1, sc1);
			go1.transform.localPosition = Vector3.zero;
			break;
		case 2:
			GameObject go2 = NGUITools.AddChild (slot1, sc2);
			go2.transform.localPosition = Vector3.zero;
			break;
		case 3:
			GameObject go3 = NGUITools.AddChild (slot1, sc3);
			go3.transform.localPosition = Vector3.zero;
			break;
		case 4:
			GameObject go4 = NGUITools.AddChild (slot1, sc4);
			go4.transform.localPosition = Vector3.zero;
			break;
		case 5:
			GameObject go5 = NGUITools.AddChild (slot1, sc5);
			go5.transform.localPosition = Vector3.zero;
			break;
		case 6:
			GameObject go6 = NGUITools.AddChild (slot1, sc6);
			go6.transform.localPosition = Vector3.zero;
			break;
		}
		
		
	}
}
