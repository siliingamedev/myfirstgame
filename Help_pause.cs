using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Help_pause : MonoBehaviour {
	public Text pause_text, name_pause, name_nAme, name_press, press_again;
	void Start (){
		name_press.GetComponent <Text> ().enabled = true;
	}
	void OnMouseDown () {
		if (PlayerPrefs.GetString ("Music") != "no")
			GameObject.Find ("Audio_Click").GetComponent <AudioSource>().Play ();
		if (pause_text.GetComponent <Text> ().enabled == false) {
			pause_text.GetComponent <Text> ().enabled = true;
			name_nAme.GetComponent <Text> ().enabled = false;
			name_pause.GetComponent <Text> ().enabled = true;
			name_press.GetComponent <Text> ().enabled = false;
			press_again.GetComponent <Text> ().enabled = true;
		} else if (pause_text.GetComponent <Text> ().enabled == true) {
			pause_text.GetComponent <Text> ().enabled = false;
			name_pause.GetComponent <Text> ().enabled = false;
			name_nAme.GetComponent <Text> ().enabled = true;
			press_again.GetComponent <Text> ().enabled = false;
			name_press.GetComponent <Text> ().enabled = true;
		}
		}
	}
