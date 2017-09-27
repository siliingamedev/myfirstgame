using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Help_shape : MonoBehaviour {
	void OnMouseDown () {
		if (PlayerPrefs.GetString ("Music") != "no")
			GameObject.Find ("Audio_Click").GetComponent <AudioSource>().Play ();
		switch (gameObject.name) {
		case "Kvadrat":
			SceneManager.LoadScene("Help_pause");
			break;
		}
	}
}
