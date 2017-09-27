using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Help_color : MonoBehaviour {
	void OnMouseDown () {
		if (PlayerPrefs.GetString ("Music") != "no")
			GameObject.Find ("Audio_Click").GetComponent <AudioSource>().Play ();
		switch (gameObject.name) {
		case "romb":
			SceneManager.LoadScene("Help_shape");
			break;
		}
	}
}
