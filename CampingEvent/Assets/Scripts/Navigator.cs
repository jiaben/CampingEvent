using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Navigator : MonoBehaviour {
	private GameObject siPlayer;
	private GameObject siMap;

	private GameObject player;

	private Vector2 WorldSize;
	private Vector2 mapSize;
	// Use this for initialization
	void Start () {
		WorldSize = new Vector2 (100, 100);
		player = GameObject.Find ("MainPlayer");
		siPlayer = GameObject.Find ("Canvas/Navigator/Pointer");
		siMap = GameObject.Find ("Canvas/Navigator");
		RectTransform rt  = siMap.transform.GetComponent<RectTransform>();
		mapSize = new Vector2 (rt.sizeDelta.x * rt.localScale.x, 
			rt.sizeDelta.y * rt.localScale.y);
		Debug.Log (mapSize.ToString());

	}

	// Update is called once per frame
	void Update () {
		Vector3 mainPlayPos = player.transform.position;
		RawImage riPlayer = siPlayer.GetComponent<RawImage> ();

		riPlayer.rectTransform.localPosition = new Vector2(
			mainPlayPos.x / WorldSize.x * mapSize.x, 
			mainPlayPos.z / WorldSize.y * mapSize.y);
	}
}
