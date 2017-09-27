using UnityEngine;
using System.Collections;

public class GreenLine : MonoBehaviour {
	public GameObject kyt, kyt1, kyt2, kyt3, kyt4, kyt5, kyt6, kyt7, kyt8;
	void Update () {
		if (PlayerPrefs.GetInt ("Game") == 0)
			kyt.GetComponent <SpriteRenderer> ().enabled = true;
		else 
			kyt.GetComponent <SpriteRenderer> ().enabled = false;
		if (PlayerPrefs.GetInt ("Game") == 1)
			kyt1.GetComponent <SpriteRenderer> ().enabled = true;
		else 
			kyt1.GetComponent <SpriteRenderer> ().enabled = false;
		if (PlayerPrefs.GetInt ("Game") == 2)
			kyt2.GetComponent <SpriteRenderer> ().enabled = true;
		else 
			kyt2.GetComponent <SpriteRenderer> ().enabled = false;
		if (PlayerPrefs.GetInt ("Game") == 3)
			kyt3.GetComponent <SpriteRenderer> ().enabled = true;
		else 
			kyt3.GetComponent <SpriteRenderer> ().enabled = false;
		if (PlayerPrefs.GetInt ("Game") == 4)
			kyt4.GetComponent <SpriteRenderer> ().enabled = true;
		else 
			kyt4.GetComponent <SpriteRenderer> ().enabled = false;
		if (PlayerPrefs.GetInt ("Game") == 5)
			kyt5.GetComponent <SpriteRenderer> ().enabled = true;
		else 
			kyt5.GetComponent <SpriteRenderer> ().enabled = false;
		if (PlayerPrefs.GetInt ("Game") == 6)
			kyt6.GetComponent <SpriteRenderer> ().enabled = true;
		else 
			kyt6.GetComponent <SpriteRenderer> ().enabled = false;
		if (PlayerPrefs.GetInt ("Game") == 7)
			kyt7.GetComponent <SpriteRenderer> ().enabled = true;
		else 
			kyt7.GetComponent <SpriteRenderer> ().enabled = false;
		if (PlayerPrefs.GetInt ("Game") == 8)
			kyt8.GetComponent <SpriteRenderer> ().enabled = true;
		else 
			kyt8.GetComponent <SpriteRenderer> ().enabled = false;
	}
}
