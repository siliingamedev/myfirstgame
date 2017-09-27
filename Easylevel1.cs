using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Easylevel1 : MonoBehaviour {
	private int minusnarker;
	void Start (){
		minusnarker = PlayerPrefs.GetInt ("Marker");
		if (PlayerPrefs.GetString ("buy_easy1") == "yes") {
			GameObject.Find ("Easy_level1").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_easylev1").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El2").GetComponent <SpriteRenderer> ().enabled = true;
		}
	}
	void Update () {
		minusnarker = PlayerPrefs.GetInt ("Marker");
	}
	void Isnobuy (){
		if (PlayerPrefs.GetInt ("Marker") >= 10) {
			minusnarker -= 10;
			if (PlayerPrefs.GetString ("Music") != "no") {
				GameObject.Find ("Audio Click1").GetComponent <AudioSource> ().Play ();
			}
			GameObject.Find ("Easy_level1").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_easylev1").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El2").GetComponent <SpriteRenderer> ().enabled = true;
			PlayerPrefs.SetString ("buy_easy1", "yes");
			PlayerPrefs.SetInt ("Game", 1);
			PlayerPrefs.SetInt ("Marker", minusnarker);
			PlayerPrefs.SetInt ("Buy_1", 1);
		}
		else {
			Handheld.Vibrate ();
		}
	}
	void Isbuy () {
		if (PlayerPrefs.GetString ("Music") != "no") {
			GameObject.Find ("Audio Click").GetComponent <AudioSource> ().Play ();
		}
		PlayerPrefs.SetInt ("Game", 1);
	}
	void OnMouseDown () {
		if (PlayerPrefs.GetInt ("Buy_1") == 0)
			Isnobuy ();
		else Isbuy ();
	}

}