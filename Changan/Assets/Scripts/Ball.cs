using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	public Transform cardTransform; 
	
	private UISprite ballSprite;
	public int ball_id;
	public string ball_name;
	
	private int ball_type;
	private string ball_icon;
	public int ball_value;
	private int ball_status;
	
	void Awake(){
		ballSprite = this.GetComponent<UISprite> ();
	}
	
	//初始化ball
	public void InitBall(ballInfo bi){
		UpdateBallId (bi.ball_id);
		UpdateBallStatus (bi.ball_status);
	}
	
	public void UpdateBallId(int id){
		CSV.GetInstance ().LoadFile (Application.dataPath + "/Res", "Ball.csv");
		for (int i = 1; i < CSV.GetInstance().m_ArrayData.Count; i++) {
			if (id == CSV.GetInstance().getInt(i,0)) {
				ball_name = CSV.GetInstance().getString(i,1);
				ball_type = CSV.GetInstance().getInt(i,2);
				ball_value = CSV.GetInstance().getInt(i,3);
				ball_icon = CSV.GetInstance().getString(i,4);
			}
		}
		ball_id = id;
		//ballSprite.name = ball_icon;
	}
	
	public void UpdateBallStatus(int status){
		ball_status = status;
		//update status label
	}
	
	public ballInfo GetBallInfo(){
		ballInfo bi;
		bi.ball_id = ball_id;
		bi.ball_status = ball_status;
		return bi;
	}
	
	public void OnBallSelected(){
		if (cardTransform.GetComponent<Card> ().AddValue (ball_value, ball_type)) {
			this.transform.parent.GetComponent<BallController> ().RemoveBall (this.gameObject);
			this.transform.parent = cardTransform;
			iTween.MoveTo (this.gameObject, cardTransform.position, 0.5f);
			this.GetComponent<TweenAlpha> ().PlayForward ();
		} else {
			
		}
	}
	
}

