using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	public bool didPlayerWin = false;
	bool rPress = false;

	public Text messageText;
	public Image flash;

	public Transform player;

	public Transform point1;
	public Transform point2;
	public Transform point3;
	public Transform point4;
	public Transform point5;

	// Use this for initialization
	void Start () {
		flash.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		//Point0 --> the starting point
		if ((player.position - Vector3.zero).magnitude < 10f) {
			messageText.text = "You must get the camera";
		} else if ((player.position - Vector3.zero).magnitude < 20f) {
			messageText.text = "";
		}

		//Point1
		if ((player.position - point1.position).magnitude < 20f) {
			if (rPress == false) {
				messageText.text = "Hold [R] and move the mouse to look around";
			} if (Input.GetKeyUp (KeyCode.R)) {
				rPress = true;
				messageText.text = "You decide to head South West towards the Solid Rocket Booster";
			}
		} else if ((player.position - point1.position).magnitude < 30f) {
			messageText.text = "";
		}

		//Point2
		if ((player.position - point2.position).magnitude < 10f) {
			messageText.text = "To the South, you see an asteroid.";
		} else if ((player.position - point2.position).magnitude < 20f) {
			messageText.text = "";
		}

		//Point3
		if ((player.position - point3.position).magnitude < 10f) {
			messageText.text = "You go East to a Disco Ball";
		} else if ((player.position - point3.position).magnitude < 20f) {
			messageText.text = "";
		}

		//Point4
		if ((player.position - point4.position).magnitude < 10f) {
			messageText.text = "South. It's hard to see, but the Camera is there";
		} else if ((player.position - point4.position).magnitude < 20f) {
			messageText.text = "";
		}

		//Point5
		if (didPlayerWin) {
			if ((player.position - point5.position).magnitude < 40f) {
				messageText.text = "With photos taken, you and your camera drift off in space";
			} else {
				messageText.text = "";
			}
			flash.enabled = true;

			Color col = flash.color;
			col.a -= 0.7f * Time.deltaTime;
			flash.color = col;
		} else if ((player.position - point5.position).magnitude < 5f) {
			messageText.text = "Press [SPACE] to snap a photo";
			if (Input.GetKey(KeyCode.Space)) {
				didPlayerWin = true;
			}
		}
	}
}
