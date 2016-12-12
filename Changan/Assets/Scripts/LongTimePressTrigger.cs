using UnityEngine;
using System.Collections.Generic;

public class LongTimePressTrigger : MonoBehaviour
{
	public float triggerTime = 0.8f;
	public float timer = 0;
	public bool isPressedOverTime = false;
	public bool isPressed = false;
	//public bool isReleased = false;
	
	static public LongTimePressTrigger current;
	
	public List<EventDelegate> onPress = new List<EventDelegate>();
	public List<EventDelegate> onRelease = new List<EventDelegate>();
	public List<EventDelegate> onClick = new List<EventDelegate>();
	
	void Update(){
		if (isPressed) {
			timer += Time.deltaTime;
			if (timer > triggerTime) {
				isPressedOverTime = true;
				isPressed = false;
				timer = 0;
				EventDelegate.Execute (onPress);
			}
		} 
	}
	
	void OnPress (bool pressed)
	{
		if (current != null) return;
		current = this;
		if (pressed) {
			isPressed = true;
		} else {
			if (isPressedOverTime) {
				isPressed = false;
				isPressedOverTime = false;
				EventDelegate.Execute (onRelease);
			} else {
				timer = 0;
				isPressed = false;
				EventDelegate.Execute (onClick);
			}
		}
		current = null;
	}
	
	
	
	/*
	void Update(){
		if (isPressed) {
			timer += Time.deltaTime;
			if (timer > triggerTime) {
				isPressedOverTime = true;
				EventDelegate.Execute (onPress);
			}
		} 
		if (isReleased) {
			timer -= Time.deltaTime;
			if (timer < 0) {
				timer = 0;
				isReleased = false;
				isPressedOverTime = false;
			}
		}
	}

	void OnPress (bool pressed)
	{
		if (current != null) return;
		current = this;
		if (pressed) {
			isPressed = true;
		} else {
			if (isPressedOverTime) {
				EventDelegate.Execute (onRelease);
				timer = 0.1f;
				isPressed = false;
				isReleased = true;
			}
		}
		current = null;
	}

	void OnClick ()
	{
		if (current != null) return;
		current = this;
		if (!isPressedOverTime) EventDelegate.Execute(onClick);
		timer = 0;
		isPressed = false;
		current = null;
	}
*/
	
}

