using UnityEngine;
using System.Collections;

public class control_talk : MonoBehaviour {
	static public int talkID;
	public GameObject TalkHead;
	public GameObject TalkBG;
	public GameObject TalkTxt;
	private UISprite BGSprite;
	private UISprite HeadSprite;
	private UILabel TalkContent;
	
	// Use this for initialization
	void Start () {
		BGSprite=TalkBG.GetComponent<UISprite>();
		HeadSprite=TalkHead.GetComponent<UISprite>();
		TalkContent=TalkTxt.GetComponent<UILabel>();
		TalkID ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void TalkID(){

		switch(talkID){
		case 1:
			BGSprite.spriteName = "city_day";
			HeadSprite.spriteName="hotel_night_fix";
			TalkContent.text="hahahaha";
			break;
		
		case 2:
			BGSprite.spriteName = "city_night";
			HeadSprite.spriteName="hotel_day_fix";
			TalkContent.text="hahahaha";
			break;
		case 3:
			Application.LoadLevel(4);
			break;
		
	}
		talkID = talkID + 1;
}
}