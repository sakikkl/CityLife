using UnityEngine;
using System.Collections;

public class test2enemy : MonoBehaviour {

	public int HP = 6000;
	private UILabel Label_HP;
	public int index;
	public test2controller controller;
	private TweenPosition takedmgTween;


	void Awake(){
		HP = 6000;
		Label_HP = this.transform.FindChild ("Label_HP").GetComponent<UILabel>();
		takedmgTween = this.GetComponent<TweenPosition> ();
		Refresh ();
	}

	public void TakeDmg(int dmg){
		takedmgTween.ResetToBeginning ();
		takedmgTween.PlayForward ();
		HP -= dmg;
		if (HP < 0) {
			HP = 0;
			Refresh ();
			GameObject.Destroy(this.gameObject,1f);
		}
		Refresh ();
	}

	private void Refresh(){
		Label_HP.text = HP.ToString ();
	}


	public void OnAimSelected(){
		controller.SwitchAim (index);
		if (controller.state == State.prepare) {
			controller.state = State.attack;
		}
	}

}
