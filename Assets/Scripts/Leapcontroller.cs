/*
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Leap;

public class Leapcontroller : MonoBehaviour {

	Controller LeapController;
	int pitch;
	int yaw;

	// Use this for initialization
	void Start () {

		LeapController = new Controller ();
	}

	// Update is called once per frame
	void Update () {

		Frame frame = LeapController.Frame (); 
		Hand hand = null;
		for (int i = 0; i < frame.Hands.Count; ++i) {
			hand = frame.Hands [i];
		}

		if (hand.PalmNormal.Pitch < -1.6f)
			pitch = 2;
		else if (hand.PalmNormal.Pitch > -1.4f)
			pitch = -2;
		else
			pitch = 0;

		if (hand.PalmNormal.Yaw > -1)
			yaw = 1;
		else if (hand.PalmNormal.Yaw < -1.2)
			yaw = 1;
		else
			yaw = 0;

		Debug.Log (hand.PalmNormal.Yaw);
		transform.Rotate (pitch, 0f , hand.PalmNormal.Roll * 2f);
		transform.Translate (0f, 0f, 1f);
		//transform.Rotate (0f, 0f , hand.PalmNormal.Roll);
		//transform.Rotate (0f, hand.PalmPosition.Yaw , 0f);
		//transform.Rotate (hand.PalmNormal.Pitch, 0f , 0f);

	}
}
*/