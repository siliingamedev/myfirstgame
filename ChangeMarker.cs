using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeMarker : MonoBehaviour {
	private int result_marker;

	void Update () {
		result_marker = PlayerPrefs.GetInt ("Marker");
		GetComponent <Text> ().text = result_marker.ToString (); 
	}
}
