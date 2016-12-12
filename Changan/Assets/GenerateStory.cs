using UnityEngine;
using System.Collections;

public class GenerateStory : MonoBehaviour {
	public GameObject slot;
	private int number;
	public GameObject story;
	public UILabel TimeLabel;
	private int randomStory;
	// Use this for initialization
	void Start () {
		TimeLabel = GetComponent<UILabel>();
	}
	
	// Update is called once per frame
	void Update () {
		number = 60-System.DateTime.Now.Second;
		TimeLabel.text=number+"";
	}

	public void CreateStory(){
		if (number == 1) {
			GameObject go = NGUITools.AddChild (slot, story);
		}
	}
}
