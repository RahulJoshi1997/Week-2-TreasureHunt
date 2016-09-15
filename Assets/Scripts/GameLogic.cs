using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	bool didPlayerWin = false;
	public Text winText;
	public Transform player;
	public Transform treasure;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (didPlayerWin) {
			winText.text = "You Win!";
		} else if ((player.position - treasure.position).magnitude < 5f) {
			winText.text = "Press [SPACE] to Win";
			if (Input.GetKey(KeyCode.Space)) {
				didPlayerWin = true;
			}
		}
	}
}
