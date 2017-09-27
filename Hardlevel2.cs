using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hardlevel2 : MonoBehaviour {
	private int minusmarker6;

	void Start (){
		minusmarker6 = PlayerPrefs.GetInt ("Marker");
		if (PlayerPrefs.GetString ("buy_hard2") == "yes") {
			GameObject.Find ("Hard_level2").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_hardlev1").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El8").GetComponent <SpriteRenderer> ().enabled = true;
		}
	}
	void Update () {
		minusmarker6 = PlayerPrefs.GetInt ("Marker");
	}
	void Isnobuy (){
		if (PlayerPrefs.GetInt ("Marker") >= 70) {
			minusmarker6 -= 70;
			if (PlayerPrefs.GetString ("Music") != "no") {
				GameObject.Find ("Audio Click1").GetComponent <AudioSource> ().Play ();
			}
			GameObject.Find ("Hard_level2").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_hardlev1").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El8").GetComponent <SpriteRenderer> ().enabled = true;
			PlayerPrefs.SetString ("buy_hard2", "yes");
			PlayerPrefs.SetInt ("Game", 7);
			PlayerPrefs.SetInt ("Marker", minusmarker6);
			PlayerPrefs.SetInt ("Buy_7", 1);
		}
		else {
			Handheld.Vibrate ();
		}
	}
	void Isbuy () {
		if (PlayerPrefs.GetString ("Music") != "no") {
			GameObject.Find ("Audio Click").GetComponent <AudioSource> ().Play ();
		}
		PlayerPrefs.SetInt ("Game", 7);
	}
	void OnMouseDown () {
		if (PlayerPrefs.GetInt ("Buy_7") == 0)
			Isnobuy ();
		else Isbuy ();
	}
}
/*	void Start (){
		if (PlayerPrefs.GetString ("buy_hard2") == "yes") {
			GameObject.Find ("Hard_level2").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_hardlev1").GetComponent <SpriteRenderer> ().enabled = false;
		}
	}
	void OnMouseDown () {
		GameObject.Find ("Hard_level2").GetComponent <Text> ().enabled = false;
		GameObject.Find ("Marker_hardlev1").GetComponent <SpriteRenderer> ().enabled = false;
		PlayerPrefs.SetInt ("Game", 7);
		//PlayerPrefs.SetString ("buy_hard2", "yes");
	}
}*/