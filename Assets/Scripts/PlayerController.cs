using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public Rigidbody playerRb;
	public float speed;
	private int count;
	public Text countText;
	public Text winText;

	void Start (){
		count = 0;
		playerRb.GetComponent<Rigidbody>();
		float speed;
		this.setCountText ();
		winText.text = "";
	}

	// Update before rendering every frame
	void Update (){

	}

	// Physics calculation related update
	void FixedUpdate (){

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		playerRb.AddForce (movement * speed);
	}

	// On colision detect
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count++;
			this.setCountText ();
		}
	}

	void setCountText(){
		countText.text = "Count " + count.ToString ();
		if(count >= 13){
			winText.text = "You win";
		}
	}
}
