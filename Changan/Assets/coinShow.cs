using UnityEngine;
using System.Collections;

public class coinShow : MonoBehaviour {
	public UILabel coinBar;
	static public int coin;

	// Use this for initialization
	void Start () {
		coin = 1000;
	}
	
	// Update is called once per frame
	void Update () {
		coinBar.text = coin + "";
	}

}
