using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause1 : MonoBehaviour {
	[HideInInspector]
	public RendObject RendObject;
	[HideInInspector]
	public int a;
	bool paused = false;
	[HideInInspector]
	public bool tap = false;
	[HideInInspector]
	public Text naMe;

	void Start () {
		RendObject = GameObject.Find ("FirstObject").GetComponent <RendObject> ();
		a = GameObject.Find ("FirstObject").GetComponent <RendObject>().tap;
		GameObject.Find("nAme").GetComponent <Text> ().enabled = true;
	}

	void OnMouseUpAsButton () 
	{
		if(!paused & GameObject.Find ("FirstObject").GetComponent <RendObject>().tap!= 0)
			{
				Time.timeScale = 0;
				paused=true;
				GameObject.Find ("FirstObject").GetComponent <RendObject>().tap--;
				RendObject.figure [0].GetComponent <BoxCollider2D>().enabled = false;
				RendObject.figure [1].GetComponent <BoxCollider2D>().enabled = false;
				RendObject.figure [2].GetComponent <BoxCollider2D>().enabled = false;
				RendObject.figure [3].GetComponent <BoxCollider2D>().enabled = false;
				GameObject.Find("nAme").GetComponent <Text> ().enabled = false;
				GameObject.Find ("pauses left").GetComponent <Text> ().enabled = true;
				GameObject.Find ("pauses left numb").GetComponent <Text> ().enabled = true;
				
			}
			else
			{
				Time.timeScale = 1;
				paused=false;
				RendObject.figure [0].GetComponent <BoxCollider2D>().enabled = true;
				RendObject.figure [1].GetComponent <BoxCollider2D>().enabled = true;
				RendObject.figure [2].GetComponent <BoxCollider2D>().enabled = true;
				RendObject.figure [3].GetComponent <BoxCollider2D>().enabled = true;
				GameObject.Find ("pauses left").GetComponent <Text> ().enabled = false;
				GameObject.Find ("pauses left numb").GetComponent <Text> ().enabled = false;
				GameObject.Find("nAme").GetComponent <Text> ().enabled = true;
		}
	}
}
