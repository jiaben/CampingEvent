using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public float speed;

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		Vector3 posToBe = transform.position + movement * speed;
		float simpleY = Terrain.activeTerrain.SampleHeight (posToBe);

		if (simpleY - 1.0f < 0.01 || simpleY - 5.5f > 0.01)
			return;

		if (posToBe.x < 1 || posToBe.x > 200)
			return;

		if (posToBe.z < 1 || posToBe.z > 200)
			return;

		transform.position = new Vector3 (posToBe.x, simpleY, posToBe.z);
		Debug.Log (transform.position.ToString ());
	}

}
