using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Easylevel : MonoBehaviour {

	void OnMouseDown () {
		if (PlayerPrefs.GetString ("Music") != "no") {
			GameObject.Find ("Audio Click").GetComponent <AudioSource> ().Play ();
		}
		PlayerPrefs.SetInt ("Game", 0);

	}
}
