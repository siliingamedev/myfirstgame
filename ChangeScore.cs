using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeScore : MonoBehaviour {
	private int result;

	void Start () {
		result = PlayerPrefs.GetInt ("Score");
		GetComponent <Text> ().text = result.ToString (); 
	}
}
