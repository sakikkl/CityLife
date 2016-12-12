using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public struct skillInfo{
	public string name;
	public int set;
	public int value;
	public int dmg;
	public string spriteName;
}

public class test2skill : MonoBehaviour {

	public UISprite[] skill_sprite;
	public List<skillInfo> skills;

	void Awake(){
		skills = new List<skillInfo> ();
		Refresh ();
	}

	public void Refresh(){
		for (int i = 0; i < skill_sprite.Length; i++) {
			if (i < skills.Count) {
				skill_sprite[i].spriteName = skills[i].spriteName;
				skill_sprite[i].transform.FindChild("Label").GetComponent<UILabel>().text = skills[i].dmg.ToString();
			} else {
				skill_sprite[i].spriteName = "";
				skill_sprite[i].transform.FindChild("Label").GetComponent<UILabel>().text = "";
			}
		}
	}

	public bool EnablePlay(test2card card){
		for (int i = 0; i<skill_sprite.Length; i++) {
			if (i < skills.Count){
				if (skills[i].name == card.name && skills[i].set == card.set){
					AddOldSkill(i,card);
					Refresh ();
					return true;
				} else if (skills[i].name == card.name && skills[i].set != card.set) {
					return false;
				}
			}
		}
		SetNewSkill (card);
		Refresh ();
		return true;
	}


	private void SetNewSkill(test2card card){
		skillInfo skill;
		skill.name = card.name;
		skill.set = card.set;
		skill.spriteName = card.spriteName;
		skill.value = card.value;
		skill.dmg = FindDmg (skill.name, skill.set, skill.value);
		skills.Add (skill);
	}

	private void AddOldSkill(int i, test2card card){
		skillInfo s = skills [i];
		s.value += card.value;
		s.dmg = FindDmg (skills[i].name, skills[i].set, s.value);
		skills[i] = s;
	}

	private int FindDmg(string name, int set, int value){
		int dmg = set * 100;
		switch (value) {
		case 1:
			dmg += 300;
			break;
		case 2:
			dmg += 400;
			break;
		case 3:
			dmg += 600;
			break;
		case 10:
			dmg += 350;
			break;
		case 11:
			dmg += 500;
			break;
		case 12:
			dmg += 650;
			break;
		case 13:
			dmg += 800;
			break;
		case 20:
			dmg += 450;
			break;
		case 21:
			dmg += 550;
			break;
		case 22:
			dmg += 700;
			break;
		case 23:
			dmg += 900;
			break;
		case 100:
			dmg += 750;
			break;
		case 101:
			dmg += 850;
			break;
		case 102:
			dmg += 1000;
			break;
		case 103:
			dmg += 1100;
			break;
		case 110:
			dmg += 950;
			break;
		case 111:
			dmg += 1100;
			break;
		case 112:
			dmg += 1200;
			break;
		case 113:
			dmg += 1500;
			break;
		case 120:
			dmg += 1300;
			break;
		case 121:
			dmg += 1600;
			break;
		case 122:
			dmg += 1800;
			break;
		case 123:
			dmg += 2000;
			break;
		}
		return dmg;
	}

	public void PlaySkill(){
		skills.RemoveAt (0);
		Refresh ();
	}


}
