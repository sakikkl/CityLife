using UnityEngine;
using System.Collections;

public class backPack : MonoBehaviour {
	public GameObject[] cells;
	public string[] equipmentsName;
	public GameObject item;
	static public int itemID;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {
			PickUp ();
		}
		if (itemID == 0) {
			PickUp ();
		}
	}
   public void PickUp(){
		//int index = Random.Range (0, equipmentsName.Length);
		//string name = equipmentsName [index];

		string name="item1";
		itemID=1;
		bool isFind = false;
		for (int i=0; i<cells.Length; i++) {
			if (cells [i].transform.childCount > 0) {
				backPackItem item=cells[i].GetComponentInChildren<backPackItem>();
				if(item.sprite.spriteName==name){
					isFind=true;
					item.AddCount(1);
					break;
				}
			}
		}
		for (int i=0; i<cells.Length; i++) {
			if (cells [i].transform.childCount == 0) {
				GameObject go = NGUITools.AddChild (cells [i], item);
				go.GetComponent<UISprite> ().spriteName = name;
				go.transform.localPosition = Vector3.zero;
				break;

			}
		}
}
}
