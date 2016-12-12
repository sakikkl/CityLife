using UnityEngine;
using System.Collections;

public class testBall : MonoBehaviour {

	public int value;
	public int type;
	public Transform card;
	private UISprite ballSprite;

	void Start(){
		ballSprite = this.GetComponent<UISprite> ();
	}

	public void InitBall(int i){
		card = this.transform.parent.GetComponent<testBallController> ().card;
		ballSprite = this.GetComponent<UISprite> ();
		value = i;
		switch (i) {
		case 1:
			ballSprite.spriteName = "wu_dugu_ball";
			type = 1;
			break;
		case 10:
			ballSprite.spriteName = "nei_dali_ball";
			type = 2;
			break;
		}
	}

	public void OnBallClicked(){
		if (card.GetComponent<testCard>().type == 0 || card.GetComponent<testCard>().type == type) {
			this.transform.parent.GetComponent<testBallController>().RemoveBall(this.gameObject);
			card.GetComponent<testCard>().AddBall(this.gameObject);
		}
	}
}
