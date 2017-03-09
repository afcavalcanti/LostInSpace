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
		Hand hand = null;
		for (int i = 0; i < frame.Hands.Count; ++i) {
			hand = frame.Hands [i];
		}

		float rotacao = 2f;
		float velocidade = 20f;

		transform.Rotate (hand.PalmNormal.Pitch, 0f , hand.PalmNormal.Roll * 2f);
		transform.Translate (hand.PalmPosition.x * 0.01f, 0f, hand.PalmPosition.z * -0.01f);

	}
}