using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class testBallController : MonoBehaviour {

	public GameObject ballPrefab;
	public List<GameObject> balls;
	public Transform card;
	public Transform[] ballSlots;

	void Awake(){
		balls = new List<GameObject> ();
	}

	public void GenreateBall(){

		GameObject ball = NGUITools.AddChild (this.gameObject, ballPrefab);
		int i = Random.Range (0, 10);
		if (i > 5) {
			ball.GetComponent<testBall> ().InitBall (10);
		} else {
			ball.GetComponent<testBall> ().InitBall(1);
		}

		balls.Add (ball);
		Refresh ();


	}
	private void Refresh(){
		for (int i = 0; i<balls.Count; i++) {
			iTween.MoveTo (balls[i], ballSlots [i].position, 1f);
		}
	}

	public void RemoveBall(GameObject ball){
		balls.Remove (ball);
		Refresh ();
	}

	public void GetBalls(){
		if (balls.Count < 4) {
			StartCoroutine(Get2Balls());
		} else if (balls.Count < 5) {
			StartCoroutine(Get1Balls());
		}
	}

	private IEnumerator Get1Balls(){
		yield return new WaitForSeconds (0.5f);
		GenreateBall ();
	}
	
	private IEnumerator Get2Balls(){
		yield return new WaitForSeconds (0.5f);
		GenreateBall ();
		yield return new WaitForSeconds (0.5f);
		GenreateBall ();
	}
}
