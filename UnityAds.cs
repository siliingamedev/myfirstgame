using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class UnityAds : MonoBehaviour {

	public int markerplus;
	void Start () {
		markerplus = PlayerPrefs.GetInt ("Marker");
	}
	void Update (){
		markerplus = PlayerPrefs.GetInt ("Marker");
	}
	void OnMouseUpAsButton () {
		ShowAd ();
	}
	public void ShowAd()
	{
		if (Advertisement.IsReady("rewardedVideo"))
		{
			Advertisement.Show("rewardedVideo",new ShowOptions {
				resultCallback = result =>
				{
					if(result == ShowResult.Finished) {
						markerplus += 3;
						PlayerPrefs.SetInt ("Marker", markerplus);
					}
				}
			});

		}
	}
}

