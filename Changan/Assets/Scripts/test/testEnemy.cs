using UnityEngine;
using System.Collections;

public class testEnemy : MonoBehaviour {

	public testCard card;

	public void OnEnmeyClicked(){
		if (card.value != 0) {
			card.CastSkill();
			GameObject.Destroy(this.gameObject, 1f);
		}
	}
}
