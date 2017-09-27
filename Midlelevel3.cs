using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Midlelevel3 : MonoBehaviour {
	private int minusmarker4;

	void Start (){
		minusmarker4 = PlayerPrefs.GetInt ("Marker");
		if (PlayerPrefs.GetString ("buy_midle3") == "yes") {
			GameObject.Find ("Medium_level3").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_medlev2").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El6").GetComponent <SpriteRenderer> ().enabled = true;
		}
	}
	void Update () {
		minusmarker4 = PlayerPrefs.GetInt ("Marker");
	}
	void Isnobuy (){
		if (PlayerPrefs.GetInt ("Marker") >= 50) {
			minusmarker4 -= 50;
			if (PlayerPrefs.GetString ("Music") != "no") {
				GameObject.Find ("Audio Click1").GetComponent <AudioSource> ().Play ();
			}
			GameObject.Find ("Medium_level3").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_medlev2").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El6").GetComponent <SpriteRenderer> ().enabled = true;
			PlayerPrefs.SetString ("buy_midle3", "yes");
			PlayerPrefs.SetInt ("Game", 5);
			PlayerPrefs.SetInt ("Marker", minusmarker4);
			PlayerPrefs.SetInt ("Buy_5", 1);
		}
		else {
			Handheld.Vibrate ();
		}
	}
	void Isbuy () {
		if (PlayerPrefs.GetString ("Music") != "no") {
			GameObject.Find ("Audio Click").GetComponent <AudioSource> ().Play ();
		}
		PlayerPrefs.SetInt ("Game", 5);
	}
	void OnMouseDown () {
		if (PlayerPrefs.GetInt ("Buy_5") == 0)
			Isnobuy ();
		else Isbuy ();
	}
}
	/*void Start (){
		if (PlayerPrefs.GetString ("buy_midle3") == "yes") {
			GameObject.Find ("Medium_level3").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_medlev2").GetComponent <SpriteRenderer> ().enabled = false;
		}
	}
	void OnMouseDown () {
		GameObject.Find ("Medium_level3").GetComponent <Text> ().enabled = false;
		GameObject.Find ("Marker_medlev2").GetComponent <SpriteRenderer> ().enabled = false;
		PlayerPrefs.SetInt ("Game", 5);
		//PlayerPrefs.SetString ("buy_midle3", "yes");
	}
}*/
