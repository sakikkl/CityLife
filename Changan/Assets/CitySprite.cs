using UnityEngine;
using System.Collections;

public class CitySprite : MonoBehaviour {
	private UISprite mapSprite;
	private string sceneName;
	// Use this for initialization
	void Start () {
	
		mapSprite = this.GetComponent<UISprite>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevelName=="city"&&TimeRotate.DayOrNight==1) {
			mapSprite.spriteName = "city_day";
		} 
		else if(Application.loadedLevelName=="city"&&TimeRotate.DayOrNight==2){
			mapSprite.spriteName = "city_night";
		}
		else if (Application.loadedLevelName=="forest"&&TimeRotate.DayOrNight==1) {
			mapSprite.spriteName = "forest_day";
		} 
		else if(Application.loadedLevelName=="forest"&&TimeRotate.DayOrNight==2){
			mapSprite.spriteName = "forest_night";
		}
		else if (Application.loadedLevelName=="home") {
			mapSprite.spriteName = "home";
		} 

}
}