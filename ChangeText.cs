using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {
	public Text loser;
	private int result;

	void Start () {
		result = PlayerPrefs.GetInt ("Result");
		GetComponent <Text> ().text = result.ToString (); 
	}
}
