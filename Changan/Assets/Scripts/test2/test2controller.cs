using UnityEngine;
using System.Collections;

public enum State{
	prepare,
	attack,
	settle,
	end
}
public class test2controller : MonoBehaviour {



	public test2generator generator;
	public test2skill scontroller;
	public State state;

	public GameObject[] hero;

	public test2enemy[] enemy;

	public int aim;

	void Awake(){
		state = State.prepare;
		aim = 0;

	}

	void Update () {
		switch (state) {
		case State.prepare:
			break;
		case State.attack:
			StartCoroutine(PlaySkill());
			state = State.settle;
			break;
		case State.settle:
			break;
		case State.end:
			generator.GetCard();
			state = State.prepare;
			break;
		}
	}

	public void OnEndClicked(){
		state = State.end;
	}

	public void OnAttackClicked(){
		if (state == State.prepare) {
			state = State.attack;
		}
	}

	public IEnumerator PlaySkill(){
		if (scontroller.skills.Count != 0) {
			if (scontroller.skills [0].name == "AA") {
				hero [0].GetComponent<TweenPosition> ().ResetToBeginning();
				hero [0].GetComponent<TweenPosition> ().PlayForward ();
			} else if (scontroller.skills [0].name == "BB") {
				hero [1].GetComponent<TweenPosition> ().ResetToBeginning();
				hero [1].GetComponent<TweenPosition> ().PlayForward ();
			} else if (scontroller.skills [0].name == "CC") {
				hero [2].GetComponent<TweenPosition> ().ResetToBeginning();
				hero [2].GetComponent<TweenPosition> ().PlayForward ();
			}
			enemy[aim].TakeDmg(scontroller.skills [0].dmg);
			yield return new WaitForSeconds (0.5f);
			scontroller.PlaySkill ();
			yield return new WaitForSeconds (1.5f);
			state = State.attack;
		} else {
			state = State.end;
		}
	}

	public void SwitchAim(int i){
		aim = i;
	}

}
