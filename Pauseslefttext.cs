using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pauseslefttext : MonoBehaviour {
	private int result;

	void Update () {
		result = GameObject.Find ("FirstObject").GetComponent <RendObject>().tap;
		GetComponent <Text> ().text = result.ToString () +  " left" ; 
	}
}