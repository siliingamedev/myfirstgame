using UnityEngine;
using System.Collections;

public class AudioClick : MonoBehaviour {
	public static AudioClick instance = null;
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