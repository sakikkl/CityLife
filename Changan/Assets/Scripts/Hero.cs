using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//用来记录角色属性，控制属性，控制单个角色的行为
public class Hero : MonoBehaviour {

	//角色属性
	public int character_id;
	public string character_name;
	public int character_type;
	public int character_attribute;
	public int character_attack;
	public int character_defend;
	public int character_hp;
	public int character_damagereduce;
	public int character_critical;
	public int character_counterback;
	public int character_doubleattack;
	public int character_dodge;

	//角色战斗基础属性
	private int base_attack;
	private int base_defend;
	private int base_hp;
	private int base_damagereduce;
	private int base_critical;
	private int base_counterback;
	private int base_doubleattack;
	private int base_dodge;
	//角色战斗实际属性
	public int hero_attack;
	public int hero_defend;
	public int hero_hp;
	public int hero_damagereduce;
	public int hero_critical;
	public int hero_counterback;
	public int hero_doubleattack;
	public int hero_dodge;


	public int[] ballSetWeight;
	public int[] ballSetID;
	public int[] skillSetID;

	public List<string[]> skillSet = new List<string[]> ();

	void Start(){
		skillSet = new List<string[]> ();
		CSV.GetInstance ().LoadFile (Application.dataPath + "/Res", "SkillSet.csv");
		for (int j = 0; j < skillSetID.Length; j++) {
			for (int i = 1; i < CSV.GetInstance().m_ArrayData.Count; i++) {
				if (skillSetID[j] == CSV.GetInstance().getInt(i,0)) {
					Debug.Log(CSV.GetInstance().getInt(i,0));
					skillSet.Add(CSV.GetInstance().m_ArrayData[i]);
					break;
				}
			}
		}
	}

	public void GetBall(){

	}

}

