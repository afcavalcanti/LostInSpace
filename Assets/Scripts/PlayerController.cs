using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Leap;

public class PlayerController : MonoBehaviour {

	Controller LeapController;

	// Use this for initialization
	void Start () {

		LeapController = new Controller ();
	}

	// Update is called once per frame
	void Update () {

		if (Fim.terminou)
            return;

		Frame frame = LeapController.Frame (); 
		Hand hand = null;
		for (int i = 0; i < frame.Hands.Count; ++i) {
			hand = frame.Hands [i];
		}

		float translacao = hand.PalmPosition.x * 0.01f; 
		float profundidade = hand.PalmPosition.z * -0.1f; 
		 
        translacao *= Time.deltaTime;
        profundidade *= Time.deltaTime;
		transform.Translate(profundidade, 0, -translacao);
	}
}