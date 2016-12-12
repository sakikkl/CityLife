using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//这个脚本来记录技能卡的合成，以及当前的技能效果
public class Card : MonoBehaviour {
	
	public List<GameObject> tempBalls;
	public Transform ballBoard;
	
	//技能相关属性
	public int value = 0;
	public int type;
	
	public int skill_id;
	public string skill_name;
	public int skill_target;
	public int skill_time;
	public int skill_balltime;
	public int skill_damage;
	public float skill_para;
	
	public List<string> skillData = new List<string>();
	
	void Awake(){
		tempBalls = new List<GameObject> ();
	}
	
	
	
	public void ReceiveBall(GameObject ball){
		tempBalls.Add (ball);
		NGUITools.SetActive (ball, false);
	}
	
	public void ClickToReturnBall(){
		if (tempBalls.Count != 0 && tempBalls.Count <= 3 - ballBoard.GetComponent<BallController>().balls.Count) {
			for (int i = 0; i < tempBalls.Count; i++) {
				NGUITools.SetActive (tempBalls[i], true);
				tempBalls.Remove (tempBalls[i]);
				ballBoard.GetComponent<BallController>().AddBall(tempBalls[i]);
			}
		}
	}
	
	public bool AddValue(int bv, int bt){
		if (type == 0 || bt == type) {
			for (int i = 0; i < this.transform.parent.GetComponent<Hero>().skillSet.Count; i++) {
				if (type == int.Parse (this.transform.parent.GetComponent<Hero> ().skillSet [i] [2]) && value == int.Parse (this.transform.parent.GetComponent<Hero> ().skillSet [i] [4]) - bv) {
					value = value + bv;
					type = bt;
					skillData = new List<string>(this.transform.parent.GetComponent<Hero>().skillSet[i]);
					SetSkillData();
					return true;
				}
			}
			return false;
		} else {
			return false;
		}
	}
	
	private void SetSkillData(){
		skill_id = int.Parse(skillData[0]);
		skill_name = skillData[1];
		skill_target = int.Parse(skillData[3]);
		skill_time = int.Parse(skillData[4]);
		skill_balltime = int.Parse(skillData[5]);
		skill_damage = int.Parse(skillData[7]);
		skill_para = float.Parse(skillData[8]);
	}
	
}

