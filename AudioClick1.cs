using UnityEngine;
using System.Collections;

public class AudioClick1 : MonoBehaviour {
	public static AudioClick1 instance = null;
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