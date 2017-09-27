using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public  class RendObject : MonoBehaviour { 
	public GameObject [] aSprite;
	public Vector3 [] position;
	public Vector3 [] positions;
	public GameObject [] prefab = new GameObject[4];
	[HideInInspector]
	public GameObject block;
	[HideInInspector]
	public int rAnd, rand, rand1, rand2, rand3, rand4, count;
	[HideInInspector]
	public bool neXt, lose;

	public Text score, nAme, markers;
	[HideInInspector]
	public GameObject [] figure = new GameObject[4];
	[HideInInspector]
	public Color aColoR;
	[HideInInspector]
	public GameObject timerline;
	public GameObject Line;
	public Vector3 LinePosition;
	public Color firstcolor, secondcolor;
	public int marker, marker_sum;
	public int tap;
	public Timer_my Timer_my;

	void Start () {
		count = 0;
		marker = PlayerPrefs.GetInt ("Marker");
		markers.text = marker.ToString ();
		neXt = false;
		lose = false;
		BuildShapes ();
		tap = 3;


	}

	void Update () {
		if (neXt) {
			Destroy (block);
			Destroy (figure [0]);
			Destroy (figure [1]);
			Destroy (figure [2]);
			Destroy (figure [3]);
			Destroy (timerline);
			NextStep ();
		}
		if (lose)
			GameLose ();

	}
	void BuildShapes () {
		rand = Random.Range (0, 10);
		if (rand >= 5)
			nAme.text = "Color";
		else if (rand < 5)
			nAme.text = "Shape";
		neXt = false;
		lose = false;
		rAnd = Random.Range (0, 4);
		block = Instantiate (aSprite [rAnd], position [rAnd], Quaternion.identity) as GameObject;
		aColoR = new Vector4 (Random.Range (0.1f, 1f), Random.Range (0.1f, 1f), Random.Range (0.1f, 1f), 1);
		block.GetComponent <SpriteRenderer> ().color = aColoR;

		rand1 = Random.Range (0, 4);
		for (; ;) {
			rand2 = Random.Range (0, 4);
			if (rand2 != rand1)
				break;
		}
		for (; ;) {
			rand3 = Random.Range (0, 4);
			if (rand3 != rand2 & rand3 != rand1)
				break;
		}
		for (; ;) {
			rand4 = Random.Range (0, 4);
			if (rand4 != rand1 & rand4 != rand2 & rand4 != rand3)
				break;
		}
		figure [0] = Instantiate (prefab [rand1], positions [0], Quaternion.identity) as GameObject; 
		figure [1] = Instantiate (prefab [rand2], positions [1], Quaternion.identity) as GameObject; 
		figure [2] = Instantiate (prefab [rand3], positions [2], Quaternion.identity) as GameObject; 
		figure [3] = Instantiate (prefab [rand4], positions [3], Quaternion.identity) as GameObject; 
		figure [0].GetComponent <SpriteRenderer> ().color = new Vector4 (Random.Range (0.1f, 1f), Random.Range (0.1f, 1f), Random.Range (0.1f, 1f), 1);
		figure [1].GetComponent <SpriteRenderer> ().color = new Vector4 (Random.Range (0.1f, 1f), Random.Range (0.1f, 1f), Random.Range (0.1f, 1f), 1);
		figure [2].GetComponent <SpriteRenderer> ().color = new Vector4 (Random.Range (0.1f, 1f), Random.Range (0.1f, 1f), Random.Range (0.1f, 1f), 1);
		figure [3].GetComponent <SpriteRenderer> ().color = new Vector4 (Random.Range (0.1f, 1f), Random.Range (0.1f, 1f), Random.Range (0.1f, 1f), 1);

		int i = rand1;
		figure [i].GetComponent <SpriteRenderer> ().color = aColoR;
		if (rand >= 5) {
			figure [0].AddComponent <RightOneColor> ();
			figure [1].AddComponent <RightOneColor> ();
			figure [2].AddComponent <RightOneColor> ();
			figure [3].AddComponent <RightOneColor> ();
		}
		else if (rand < 5) {
			figure [0].AddComponent <RightOneShape> ();
			figure [1].AddComponent <RightOneShape> ();
			figure [2].AddComponent <RightOneShape> ();
			figure [3].AddComponent <RightOneShape> ();
		}	
		timerline = Instantiate (Line, LinePosition, Quaternion.identity) as GameObject;
	}
	void NextStep () {
		count++;
		score.text = count.ToString ();
		if (count % 10 == 0) {
			if (PlayerPrefs.GetString ("Music") != "no") {
				GameObject.Find ("Marker_UP").GetComponent <AudioSource> ().Play ();
			}
			marker ++;
		}
		markers.text = marker.ToString ();
		BuildShapes ();
	}
	void GameLose (){
		SceneManager.LoadScene ("Retry_Menu");
		if (PlayerPrefs.GetInt ("Score") < count)
		PlayerPrefs.SetInt ("Score", count);
		PlayerPrefs.SetInt ("Result", count);
		PlayerPrefs.SetInt ("Marker", marker);
	}
}



