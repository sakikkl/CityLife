using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class test2generator : MonoBehaviour {

	public GameObject cardPref;
	public List<GameObject> cards;
	public Transform[] slots;


	void Awake(){
		cards = new List<GameObject> ();
		GetStartHand ();
	}

	public void Refresh(){
		for (int i = 0; i < cards.Count; i++) {
			iTween.MoveTo(cards[i],slots[i].position,1f);
		}
	}

	public void RandomGenerate(){
		GameObject card = NGUITools.AddChild (this.gameObject, cardPref);
		int i = Random.Range (1, 31);
		if (i < 4) {
			card.GetComponent<test2card> ().InitCard (1);
		} else if (i < 6) {
			card.GetComponent<test2card> ().InitCard (2);
		} else if (i < 9) {
			card.GetComponent<test2card> ().InitCard (3);
		} else if (i < 12) {
			card.GetComponent<test2card> ().InitCard (4);
		} else if (i < 15) {
			card.GetComponent<test2card> ().InitCard (5);
		} else if (i < 17) {
			card.GetComponent<test2card> ().InitCard (6);
		} else if (i < 20) {
			card.GetComponent<test2card> ().InitCard (7);
		} else if (i < 22) {
			card.GetComponent<test2card> ().InitCard (8);
		} else if (i < 25) {
			card.GetComponent<test2card> ().InitCard (9);
		} else if (i < 27) {
			card.GetComponent<test2card> ().InitCard (10);
		} else if (i < 28) {
			card.GetComponent<test2card> ().InitCard (11);
		} else if (i < 31) {
			card.GetComponent<test2card> ().InitCard (12);
		}
		cards.Add (card);
	}

	public void GetCard(){
		if (cards.Count < 3) {
			StartCoroutine(RoundGenerate3());
		} else if (cards.Count < 4) {
			StartCoroutine(RoundGenerate2());
		} else if (cards.Count < 5) {
			StartCoroutine(RoundGenerate1());
		}
	}

	public void GetStartHand(){
		RandomGenerate ();
		Refresh ();
		RandomGenerate ();
		Refresh ();
		RandomGenerate ();
		Refresh ();
		RandomGenerate ();
		Refresh ();
		RandomGenerate ();
		Refresh ();
	}

	private IEnumerator RoundGenerate1(){
		Refresh ();
		yield return new WaitForSeconds (0.5f);
		RandomGenerate ();
		Refresh ();
	}
	private IEnumerator RoundGenerate2(){
		Refresh ();
		yield return new WaitForSeconds (0.5f);
		RandomGenerate ();
		Refresh ();
		yield return new WaitForSeconds (0.5f);
		RandomGenerate ();
		Refresh ();
	}

	private IEnumerator RoundGenerate3(){
		Refresh ();
		yield return new WaitForSeconds (0.5f);
		RandomGenerate ();
		Refresh ();
		yield return new WaitForSeconds (0.5f);
		RandomGenerate ();
		Refresh ();
		yield return new WaitForSeconds (0.5f);
		RandomGenerate ();
		Refresh ();
	}
}
