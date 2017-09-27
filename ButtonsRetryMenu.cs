using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonsRetryMenu : MonoBehaviour {
	public Sprite layer_blue, layer_red;
	void OnMouseDown () {
		GetComponent <SpriteRenderer> ().sprite = layer_red;
	}

	void OnMouseUp () {
		GetComponent <SpriteRenderer> ().sprite = layer_blue;
	}

	void OnMouseUpAsButton () {
		if (PlayerPrefs.GetString ("Music") != "no")
		GameObject.Find ("Audio Click").GetComponent <AudioSource>().Play ();
		switch (gameObject.name) {
		case "Back":
			SceneManager.LoadScene("Start_menu");
			break;
		case "Retry":
			if (PlayerPrefs.GetInt ("Game") == 0)
				SceneManager.LoadScene("Game");
			else if (PlayerPrefs.GetInt ("Game") == 1)
				SceneManager.LoadScene("Game_level1");
			else if (PlayerPrefs.GetInt ("Game") == 2)
				SceneManager.LoadScene("Game_level2");
			else if (PlayerPrefs.GetInt ("Game") == 3)
				SceneManager.LoadScene("Game_level3");
			else if (PlayerPrefs.GetInt ("Game") == 4)
				SceneManager.LoadScene("Game_level4");
			else if (PlayerPrefs.GetInt ("Game") == 5)
				SceneManager.LoadScene("Game_level5");
			else if (PlayerPrefs.GetInt ("Game") == 6)
				SceneManager.LoadScene("Game_level6");
			else if (PlayerPrefs.GetInt ("Game") == 7)
				SceneManager.LoadScene("Game_level7");
			else if (PlayerPrefs.GetInt ("Game") == 8)
				SceneManager.LoadScene("Game_level8");
			break;
		case "Help":
			SceneManager.LoadScene("Help");
			break;
		case "Shop":
			SceneManager.LoadScene("Shop");
			break;
		}
	}
}