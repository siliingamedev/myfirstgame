using UnityEngine;
using System.Collections;

public class RightOneColor : MonoBehaviour {
	public RendObject RendObject;
	private GameObject mainCube;

	void Start (){
		RendObject = GameObject.Find ("FirstObject").GetComponent <RendObject> ();
	}
	void OnMouseDown () {
		if (PlayerPrefs.GetString ("Music") != "no")
		GameObject.Find ("Audio_Click").GetComponent <AudioSource>().Play ();
		mainCube = RendObject.block;
		if (GetComponent <SpriteRenderer> ().color == mainCube.GetComponent <SpriteRenderer> ().color) 
			GameObject.Find("FirstObject").GetComponent <RendObject> ().neXt = true;
		else {
			if (PlayerPrefs.GetString ("Music") != "no") {
				Handheld.Vibrate ();
			}
			GameObject.Find ("FirstObject").GetComponent <RendObject> ().lose = true;
		}
	}
}