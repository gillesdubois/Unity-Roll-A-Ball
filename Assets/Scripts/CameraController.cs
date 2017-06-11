using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		GameObject player = new GameObject ();
		offset = transform.position - player.transform.position;
	}
	
	// Update after everyobject has been process in update
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
