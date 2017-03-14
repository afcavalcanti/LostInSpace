using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Leap;

public class Leapcontroller : MonoBehaviour {

	Controller LeapController;

	// Use this for initialization
	void Start () {
		LeapController = new Controller ();
	}

	// Update is called once per frame
	void Update () {

		Frame frame = LeapController.Frame ();
		if (frame.Hands.Count > 0) {
			
			List<Hand> hands = frame.Hands;
			Hand hand = hands [0];


			if (hand.PalmNormal.Roll > 0.5f || hand.PalmNormal.Roll < -0.5f) {
				transform.Rotate (0f, 0f, hand.PalmNormal.Roll);
			}
			if (hand.PalmNormal.Pitch > -0.9f) {
				transform.Rotate (hand.PalmNormal.Pitch * 0.8f, 0f, 0f);
			}
			if (hand.PalmNormal.Pitch < -1.5f) {
				transform.Rotate (-hand.PalmNormal.Pitch * 0.2f, 0f, 0f);
			}/*
			if (hand.PalmNormal.Yaw > 0.4f || hand.PalmNormal.Yaw < -0.4f) {
				transform.Rotate (0f, hand.PalmNormal.Yaw, 0f);
			}*/
			if (hand.PalmPosition.x > 20f || hand.PalmPosition.x < -20f) {
				transform.Translate (hand.PalmPosition.x * 0.005f, 0f, 0f);
			}
			if (hand.PalmPosition.z > 60f || hand.PalmPosition.z < -40f) {
				transform.Translate (0f, 0f, -hand.PalmPosition.z * 0.005f);
			}
				
		}
	}
}