using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControl : MonoBehaviour {

	public GameObject mainPlayer;

	private Vector3 offset;

	void Start(){
		offset = transform.position - mainPlayer.transform.position;
	}

	void LateUpdate(){
		transform.position = mainPlayer.transform.position + offset;
	}
}
