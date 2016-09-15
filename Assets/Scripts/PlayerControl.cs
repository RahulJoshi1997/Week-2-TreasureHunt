using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	float movementSpeed;

	// Use this for initialization
	void Start () {
		movementSpeed = 10f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.position += new Vector3 (0f, 0f, movementSpeed) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0f, 0f, 0f);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position += new Vector3 (0f, 0f, -movementSpeed) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0f, 180f, 0f);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position += new Vector3 (movementSpeed, 0f, 0f) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0f, -90f, 0f);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (-movementSpeed, 0f, 0f) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0f, 90f, 0f);
		}
		//Move the camera along with the player but offset it
		Camera.main.transform.position = transform.position + new Vector3 (0f, 1.98f, -3.57f);
	}
}
