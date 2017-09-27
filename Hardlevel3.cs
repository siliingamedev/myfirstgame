using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hardlevel3 : MonoBehaviour {
	private int minusmarker7;
	void Start (){
		minusmarker7 = PlayerPrefs.GetInt ("Marker");
		if (PlayerPrefs.GetString ("buy_hard3") == "yes") {
			GameObject.Find ("Hard_level3").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_hardlev").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El9").GetComponent <SpriteRenderer> ().enabled = true;
		}
	}
	void Update () {
		minusmarker7 = PlayerPrefs.GetInt ("Marker");
	}
	void Isnobuy (){
		if (PlayerPrefs.GetInt ("Marker") >= 80) {
			minusmarker7 -= 80;
			if (PlayerPrefs.GetString ("Music") != "no") {
				GameObject.Find ("Audio Click1").GetComponent <AudioSource> ().Play ();
			}
			GameObject.Find ("Hard_level3").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_hardlev").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El9").GetComponent <SpriteRenderer> ().enabled = true;
			PlayerPrefs.SetString ("buy_hard3", "yes");
			PlayerPrefs.SetInt ("Game", 8);
			PlayerPrefs.SetInt ("Marker", minusmarker7);
			PlayerPrefs.SetInt ("Buy_8", 1);
		} else {
			Handheld.Vibrate ();
		}
	}
	void Isbuy () {
		if (PlayerPrefs.GetString ("Music") != "no") {
			GameObject.Find ("Audio Click").GetComponent <AudioSource> ().Play ();
		}
			PlayerPrefs.SetInt ("Game", 8);
	}
	void OnMouseDown () {
		if (PlayerPrefs.GetInt ("Buy_8") == 0)
			Isnobuy ();
		else Isbuy ();
	}
}
/*	void Start (){
		if (PlayerPrefs.GetString ("buy_hard3") == "yes") {
			GameObject.Find ("Hard_level3").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_hardlev").GetComponent <SpriteRenderer> ().enabled = false;
		}
	}
	void OnMouseDown () {
		GameObject.Find ("Hard_level3").GetComponent <Text> ().enabled = false;
		GameObject.Find ("Marker_hardlev").GetComponent <SpriteRenderer> ().enabled = false;
		PlayerPrefs.SetInt ("Game", 8);
		//PlayerPrefs.SetString ("buy_hard3", "yes");
	}
}*/