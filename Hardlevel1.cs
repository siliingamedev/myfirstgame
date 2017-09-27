using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hardlevel1 : MonoBehaviour {
	private int minusmarker5;

	void Start (){
		minusmarker5 = PlayerPrefs.GetInt ("Marker");
		if (PlayerPrefs.GetString ("buy_hard1") == "yes") {
			GameObject.Find ("Hard_level1").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_hardlev2").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El7").GetComponent <SpriteRenderer> ().enabled = true;
		}
	}
	void Update () {
		minusmarker5 = PlayerPrefs.GetInt ("Marker");
	}
	void Isnobuy (){
		if (PlayerPrefs.GetInt ("Marker") >= 60) {
			minusmarker5 -= 60;
			if (PlayerPrefs.GetString ("Music") != "no") {
				GameObject.Find ("Audio Click1").GetComponent <AudioSource> ().Play ();
			}
			GameObject.Find ("Hard_level1").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_hardlev2").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El7").GetComponent <SpriteRenderer> ().enabled = true;
			PlayerPrefs.SetString ("buy_hard1", "yes");
			PlayerPrefs.SetInt ("Game", 6);
			PlayerPrefs.SetInt ("Marker", minusmarker5);
			PlayerPrefs.SetInt ("Buy_6", 1);
		}
		else {
			Handheld.Vibrate ();
		}
	}
	void Isbuy () {
		if (PlayerPrefs.GetString ("Music") != "no") {
			GameObject.Find ("Audio Click").GetComponent <AudioSource> ().Play ();
		}
		PlayerPrefs.SetInt ("Game", 6);
	}
	void OnMouseDown () {
		if (PlayerPrefs.GetInt ("Buy_6") == 0)
			Isnobuy ();
		else Isbuy ();
	}
}
/*void Start (){
		if (PlayerPrefs.GetString ("buy_hard1") == "yes") {
			GameObject.Find ("Hard_level1").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_hardlev2").GetComponent <SpriteRenderer> ().enabled = false;
		}
	}
	void OnMouseDown () {
		GameObject.Find ("Hard_level1").GetComponent <Text> ().enabled = false;
		GameObject.Find ("Marker_hardlev2").GetComponent <SpriteRenderer> ().enabled = false;
		PlayerPrefs.SetInt ("Game", 6);
		//PlayerPrefs.SetString ("buy_hard1", "yes");
	}
}*/