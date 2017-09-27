using UnityEngine;
using System.Collections;

public class Color_Lepestok : MonoBehaviour {
	private Color l_color;

	void Start () {
		l_color = new Vector4 (Random.Range (0.1f, 1f), Random.Range (0.1f, 1f), Random.Range (0.1f, 1f), 1);
		GetComponent <SpriteRenderer> ().color = l_color;
	}
}
