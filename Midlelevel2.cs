using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Midlelevel2 : MonoBehaviour {
	private int minusmarker3;

	void Start (){
		minusmarker3 = PlayerPrefs.GetInt ("Marker");
		if (PlayerPrefs.GetString ("buy_midle2") == "yes") {
			GameObject.Find ("Medium_level2").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_medlev1").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El5").GetComponent <SpriteRenderer> ().enabled = true;
		}
	}
	void Update (){
		minusmarker3 = PlayerPrefs.GetInt ("Marker");
	}
	void Isnobuy (){
		if (PlayerPrefs.GetInt ("Marker") >= 40) {
			minusmarker3 -= 40;
			if (PlayerPrefs.GetString ("Music") != "no") {
				GameObject.Find ("Audio Click1").GetComponent <AudioSource> ().Play ();
			}
			GameObject.Find ("Medium_level2").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_medlev1").GetComponent <SpriteRenderer> ().enabled = false;
			GameObject.Find ("El5").GetComponent <SpriteRenderer> ().enabled = true;
			PlayerPrefs.SetString ("buy_midle2", "yes");
			PlayerPrefs.SetInt ("Game", 4);
			PlayerPrefs.SetInt ("Marker", minusmarker3);
			PlayerPrefs.SetInt ("Buy_4", 1);
		}
		else {
			Handheld.Vibrate ();
		}
	}
	void Isbuy () {
		if (PlayerPrefs.GetString ("Music") != "no") {
			GameObject.Find ("Audio Click").GetComponent <AudioSource> ().Play ();
		}
		PlayerPrefs.SetInt ("Game", 4);
	}
	void OnMouseDown () {
		if (PlayerPrefs.GetInt ("Buy_4") == 0)
			Isnobuy ();
		else Isbuy ();
	}
}
	/*void Start (){
		if (PlayerPrefs.GetString ("buy_midle2") == "yes") {
			GameObject.Find ("Medium_level2").GetComponent <Text> ().enabled = false;
			GameObject.Find ("Marker_medlev1").GetComponent <SpriteRenderer> ().enabled = false;
		}
	}
	void OnMouseDown () {
		GameObject.Find ("Medium_level2").GetComponent <Text> ().enabled = false;
		GameObject.Find ("Marker_medlev1").GetComponent <SpriteRenderer> ().enabled = false;
		PlayerPrefs.SetInt ("Game", 4);
		//PlayerPrefs.SetString ("buy_midle2", "yes");
	}
}*/
