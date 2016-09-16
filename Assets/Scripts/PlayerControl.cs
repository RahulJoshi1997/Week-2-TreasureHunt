using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	float movementSpeed;
	float rotationSpeed;

	// Use this for initialization
	void Start () {
		movementSpeed = 5f;
		rotationSpeed = 5f;
	}
	
	// Update is called once per frame
	void Update () {
		//Moving the player
		if (Input.GetKey (KeyCode.W)) {
			transform.position += new Vector3 (0f, 0f, movementSpeed) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (90f, 0f, 0f);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position += new Vector3 (0f, 0f, -movementSpeed) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (90f, 180f, 0f);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position += new Vector3 (-movementSpeed, 0f, 0f) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (90f, -90f, 0f);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (movementSpeed, 0f, 0f) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (90f, 90f, 0f);
		}
		//Move the camera along with the player but offset it
		Camera.main.transform.position = transform.position + new Vector3 (0f, 1.98f, -3.57f);

		//Rotating the Camera
		float rotateAxisY = 0f;
		float rotateAxisX = 0f;

		rotateAxisY += rotationSpeed * Input.GetAxis ("Mouse X");
		rotateAxisX += rotationSpeed * Input.GetAxis ("Mouse Y");
		//Camera.main.transform.eulerAngles = new Vector3 (rotateX, rotateY, 0f);
		Camera.main.transform.Rotate(new Vector3 (-rotateAxisX, rotateAxisY, 0f));
		//Reset camera
		if (Input.GetKeyDown (KeyCode.R)) {
			Camera.main.transform.eulerAngles = new Vector3 (17.734f, 0f, 0f);
		}
	}
}
