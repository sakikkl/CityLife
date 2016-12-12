using UnityEngine;
using System.Collections;

public enum GameState{
	Game_Ready,	//初始准备
	Round_Start,
	Round_Play,
	Round_End
}

public class GameController : MonoBehaviour {

	public static GameController _instance;
	//回合事件，参数是接下来的回合行动的一方
	public delegate void OnNewRoundEvent(string heroName);
	public event OnNewRoundEvent OnNewRound;
	public int round_count;

	public GameState gameState = GameState.Game_Ready;

	public string current_hero_name;

	void Awake(){
		_instance = this;
		round_count = 0;
		gameState = GameState.Game_Ready;
		current_hero_name = "Hero_1";
	}

	void Start(){

	}

	void Update(){
		switch (gameState) {
		case GameState.Game_Ready:
			break;
		case GameState.Round_Start:
			break;
		case GameState.Round_Play:
			break;
		case GameState.Round_End:
			break;
		}
	}

	private IEnumerator GenerateStartHand(){
		yield return new WaitForSeconds (0.5f);

	}
}
