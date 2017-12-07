using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavigatorControler : MonoBehaviour {
	private GameObject siPlayer;
	private GameObject siMap;

	private GameObject player;

	private Vector2 WorldSize;
	private Vector2 mapSize;

	// Use this for initialization
	void Start () {
		WorldSize = new Vector2 (200, 200);
		player = GameObject.Find ("GameObject");
		siPlayer = GameObject.Find ("Canvas/NavigatorMap/Viewer");
		siMap = GameObject.Find ("Canvas/NavigatorMap");
		siPlayer.GetComponent<Image> ().rectTransform.anchoredPosition = new Vector2 (0.0f, 0.0f);
		RectTransform rt  = siMap.transform.GetComponent<RectTransform>();
		mapSize = new Vector2 (rt.sizeDelta.x * rt.localScale.x, 
			rt.sizeDelta.y * rt.localScale.y);
		
	}
	
	// Update is called once per frame
	// Update is called once per frame
	void Update () {
		Vector3 mainPlayPos = player.transform.position;

		Image riPlayer = siPlayer.GetComponent<Image> ();


		Vector2 locationPos = new Vector2(
			mainPlayPos.x / WorldSize.x * mapSize.x - mapSize.x/2, 
			mainPlayPos.z / WorldSize.y * mapSize.y - mapSize.y/2);
		Debug.Log (locationPos.ToString ());
		riPlayer.rectTransform.localPosition = locationPos;
	}
}
