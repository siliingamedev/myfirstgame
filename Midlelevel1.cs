using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Midlelevel1 : MonoBehaviour {
	private int minusmarker2;

	void Start (){
		minusmarker2 = PlayerPrefs.GetInt ("Marker");
		if (PlayerPrefs.GetString ("buy_midle1") == "yes") {
			GameObject.Find ("Medium_level1").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_medlev").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El4").GetComponent <SpriteRenderer> ().enabled = true;
		}
	}
	void Update () {
		minusmarker2 = PlayerPrefs.GetInt ("Marker");
	}
	void Isnobuy (){
		if (PlayerPrefs.GetInt ("Marker") >= 30) {
			minusmarker2 -= 30;
			if (PlayerPrefs.GetString ("Music") != "no") {
				GameObject.Find ("Audio Click1").GetComponent <AudioSource> ().Play ();
			}
			GameObject.Find ("Medium_level1").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_medlev").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El4").GetComponent <SpriteRenderer> ().enabled = true;
			PlayerPrefs.SetString ("buy_midle1", "yes");
			PlayerPrefs.SetInt ("Game", 3);
			PlayerPrefs.SetInt ("Marker", minusmarker2);
			PlayerPrefs.SetInt ("Buy_3", 1);
		}
		else {
			Handheld.Vibrate ();
		}
	}
	void Isbuy () {
		if (PlayerPrefs.GetString ("Music") != "no") {
			GameObject.Find ("Audio Click").GetComponent <AudioSource> ().Play ();
		}
		PlayerPrefs.SetInt ("Game", 3);
	}
	void OnMouseDown () {
		if (PlayerPrefs.GetInt ("Buy_3") == 0)
			Isnobuy ();
		else Isbuy ();
	}
}