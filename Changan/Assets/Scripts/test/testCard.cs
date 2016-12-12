using UnityEngine;
using System.Collections;

public class testCard : MonoBehaviour {

	public int type;
	public int value;
	private UISprite cardSprite;

	void Awake(){
		cardSprite = this.GetComponent<UISprite> ();
	}

	void Start(){
		RefreshCard ();
	}

	public void AddBall(GameObject ball){
		ball.transform.parent = this.transform;
		type = ball.GetComponent<testBall> ().type;
		value += ball.GetComponent<testBall> ().value;
		GameObject.Destroy (ball, 0.5f);
		RefreshCard ();
	}

	public void CastSkill(){
		type = 0;
		value = 0;
		RefreshCard ();
	}

	private void RefreshCard(){
		switch (value) {
		case 0:
			cardSprite.spriteName = "";
			break;
		case 1:
			cardSprite.spriteName = "wu_dugu_skill1";
			break;
		case 2:
			cardSprite.spriteName = "wu_dugu_skill2";
			break;
		case 3:
			cardSprite.spriteName = "wu_dugu_skill3";
			break;
		case 10:
			cardSprite.spriteName = "nei_dali_skill1";
			break;
		case 20:
			cardSprite.spriteName = "nei_dali_skill2";
			break;
		case 30:
			cardSprite.spriteName = "nei_dali_skill3";
			break;
		}
	}
}
