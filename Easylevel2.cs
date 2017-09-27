using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Easylevel2 : MonoBehaviour {
	private int minusmarker1;
	void Start (){
		minusmarker1 = PlayerPrefs.GetInt ("Marker");
		if (PlayerPrefs.GetString ("buy_easy2") == "yes") {
			GameObject.Find ("Easy_level2").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_easylev").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El3").GetComponent <SpriteRenderer> ().enabled = true;
		}
	}
	void Update () {
		minusmarker1 = PlayerPrefs.GetInt ("Marker");
	}
	void Isnobuy (){
		if (PlayerPrefs.GetInt ("Marker") >= 20) {
			minusmarker1 -= 20;
			if (PlayerPrefs.GetString ("Music") != "no") {
				GameObject.Find ("Audio Click1").GetComponent <AudioSource> ().Play ();
			}
			GameObject.Find ("Easy_level2").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_easylev").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El3").GetComponent <SpriteRenderer> ().enabled = true;
			PlayerPrefs.SetString ("buy_easy2", "yes");
			PlayerPrefs.SetInt ("Game", 2);
			PlayerPrefs.SetInt ("Marker", minusmarker1);
			PlayerPrefs.SetInt ("Buy_2", 1);
		}
		else {
			Handheld.Vibrate ();
		}
	}
	void Isbuy () {
		if (PlayerPrefs.GetString ("Music") != "no") {
			GameObject.Find ("Audio Click").GetComponent <AudioSource> ().Play ();
		}
		PlayerPrefs.SetInt ("Game", 2);
	}
	void OnMouseDown () {
		if (PlayerPrefs.GetInt ("Buy_2") == 0)
			Isnobuy ();
		else Isbuy ();
	}
}