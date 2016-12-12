using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//控制单个角色的ball
public struct ballInfo{
	public int ball_id;			
	public int ball_status;		//ball的状态id
}

public class BallController : MonoBehaviour {
	
	public GameObject ballPrefab;
	public List<GameObject> balls = new List<GameObject> ();
	
	private List<int> ballSetID = new List<int>() ;
	private List<int> c_ballSetWeight = new List<int>() ;
	
	//ball的抽取相关
	public List<int> nextBallId = new List<int> ();
	public List<int> nextBallStatus = new List<int> ();
	
	void Awake(){
		balls = new List<GameObject> ();
	}
	
	void Start(){
		RefreshBallSet();
	}
	
	
	
	public GameObject BallGenerator(int ballid){
		GameObject ball = NGUITools.AddChild (this.gameObject, ballPrefab);
		//初始化ball的信息
		ballInfo bi;
		
		//生成ball的id
		if (nextBallId.Count == 0) {
			//没有预先ball，从box中随机产生
			bi.ball_id = RandomGenerateBallID();
		} else {
			//如果有预先ball，则产生预先ball
			bi.ball_id = nextBallId[0];
			nextBallId.RemoveAt(0);
		}
		
		//生成ball的status
		if (nextBallStatus.Count == 0) {
			//没有预先status，产生默认status
			bi.ball_status = 30000;
		} else {
			//按照情况生成status
			if (nextBallStatus[0] > 0) {
				bi.ball_status = nextBallStatus[0];
				nextBallStatus.RemoveAt(0);
			} else {
				//产生随机status
				bi.ball_status = Random.Range(30001,30009);
			}
		}
		
		ball.GetComponent<Ball> ().InitBall (bi);
		return ball;
	}
	
	private void RefreshBallSet(){
		ballSetID = new List<int> ();
		c_ballSetWeight = new List<int> ();
		c_ballSetWeight.Add (0);
		for (int i = 0; i < this.transform.parent.GetComponent<Hero>().ballSetID.Length; i++) {
			ballSetID.Add(this.transform.parent.GetComponent<Hero>().ballSetID[i]);
			c_ballSetWeight.Add(c_ballSetWeight[i]+this.transform.parent.GetComponent<Hero>().ballSetWeight[i]);
		}
	}
	
	private int RandomGenerateBallID(){
		int index = Random.Range (1, c_ballSetWeight [c_ballSetWeight.Count - 1]);
		for (int i = 0; i < c_ballSetWeight.Count; i++) {
			if (index <= c_ballSetWeight[i]) {
				return ballSetID[i-1];
				break;
			}
		}
		return 0;
	}
	
	//移出
	public void RemoveBall(GameObject ball){
		balls.Remove (ball);
	}
	//加入
	public void AddBall(GameObject ball){
		ball.transform.parent = this.transform;
		balls.Add (ball);
	}
	
	
	
}

