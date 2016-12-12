using UnityEngine;
using System.Collections;

public class BuyAdd : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void BuyItem(){
		coinShow.coin-= 100;
		backPack.itemID = 0;
	}
}
