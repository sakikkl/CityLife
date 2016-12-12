using UnityEngine;
using System.Collections;

public class test2card : MonoBehaviour {

	public int id;
	public string name;
	public int set;
	public int value;
	public string spriteName;

	private UISprite card_sprite;
	private UILabel label_hero;
	private UILabel label_set;
	private test2skill skill_controller;

	public void OnSelected(){
		if (skill_controller.EnablePlay(this)) {
			this.transform.parent.GetComponent<test2generator>().cards.Remove(this.gameObject);
			this.transform.parent.GetComponent<test2generator>().Refresh();
			GameObject.Destroy(this.gameObject, 0.5f);
		}
	}

	public void InitCard(int i){
		skill_controller = this.transform.parent.parent.FindChild ("Container_skill").GetComponent<test2skill> ();
		card_sprite = this.transform.FindChild ("card_sprite").GetComponent<UISprite> ();
		label_hero = this.transform.FindChild ("Label_hero").GetComponent<UILabel> ();
		label_set = this.transform.FindChild ("Label_set").GetComponent<UILabel> ();
		id = i;
		switch (i) {
		case 1:
			name = "AA";
			set = 1;
			value = 1;
			spriteName = "nei_dali_skill1";
			break;
		case 2:
			name = "AA";
			set = 1;
			value = 10;
			spriteName = "nei_dali_skill2";
			break;
		case 3:
			name = "AA";
			set = 2;
			value = 1;
			spriteName = "nei_dali_skill3";
			break;
		case 4:
			name = "AA";
			set = 3;
			value = 1;
			spriteName = "nei_dali_ball";
			break;
		case 5:
			name = "BB";
			set = 1;
			value = 1;
			spriteName = "nei_taiji_ball";
			break;
		case 6:
			name = "BB";
			set = 1;
			value = 10;
			spriteName = "nei_taiji_skill1";
			break;
		case 7:
			name = "BB";
			set = 2;
			value = 1;
			spriteName = "nei_taiji_skill2";
			break;
		case 8:
			name = "BB";
			set = 2;
			value = 10;
			spriteName = "nei_taiji_skill3";
			break;
		case 9:
			name = "CC";
			set = 1;
			value = 1;
			spriteName = "nei_jinyan_skill1";
			break;
		case 10:
			name = "CC";
			set = 1;
			value = 10;
			spriteName = "nei_jinyan_skill2";
			break;
		case 11:
			name = "CC";
			set = 1;
			value = 100;
			spriteName = "nei_jinyan_skill3";
			break;
		case 12:
			name = "CC";
			set = 2;
			value = 1;
			spriteName = "nei_jinyan_ball";
			break;
		}
		card_sprite.spriteName = spriteName;
		label_hero.text = name.ToString();
		label_set.text = set.ToString();
	}

}
