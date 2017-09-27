using UnityEngine;
using System.Collections;

public class Timer_my : MonoBehaviour {
	public Color firstcolor, secondcolor;
	public float speed;
	void Update () {
		transform.position += Vector3.left * speed * Time.deltaTime;
		GetComponent <SpriteRenderer> ().color = firstcolor;
		if (transform.position.x < -6.1f) 
			GameObject.Find("FirstObject").GetComponent <RendObject> ().lose = true;
 	}
}
