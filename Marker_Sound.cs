using UnityEngine;
using System.Collections;

public class Marker_Sound : MonoBehaviour {
	public static Marker_Sound instance = null;
	void Start () {
		if (instance != null){
			Destroy (gameObject);
		Debug.Log ("One Music Destroyed");
		return;
	}
	instance = this;
		DontDestroyOnLoad (gameObject);
	}

}