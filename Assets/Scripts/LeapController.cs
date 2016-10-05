using UnityEngine;
using System.Collections;
using Leap;

public class LeapController : MonoBehaviour {

	Controller m_leapController;
	GameObject m_carriedObject;
	bool m_handOpenThisFrame = false;
	bool m_handOpenLastFrame = false;

	// Use this for initialization
	void Start () {
		m_leapController = new Controller();
	}

	Hand GetForeMostHand() {
		Frame f = m_leapController.Frame();
		Hand foremostHand = null;
		float zMax = -float.MaxValue;
		for(int i = 0; i < f.Hands.Count; ++i) {
			float palmZ = f.Hands [i].PalmPosition.z;
			if (palmZ > zMax) {
				zMax = palmZ;
				foremostHand = f.Hands[i];
			}
		}

		return foremostHand;
	}

	void OnHandOpen(Hand h) {
		transform.Translate (1f * PlayerController.velocidade, 0, 1f * PlayerController.velocidade);
	}

	void OnHandClose(Hand h) {
		transform.Translate (1f * PlayerController.velocidade, 0, -1f * PlayerController.velocidade);
	}

	bool IsHandOpen(Hand h) {
		return h.Fingers.Count > 1; 
	}

	void HandCallbacks(Hand h) {
		while (m_handOpenThisFrame && m_handOpenLastFrame == false) {
			OnHandOpen(h);
		}

		while (m_handOpenThisFrame == false && m_handOpenLastFrame == true) {
			OnHandClose(h); 
		}
	}

	void FixedUpdate () {
		Hand foremostHand = GetForeMostHand();
		if (foremostHand != null) {
			m_handOpenThisFrame = IsHandOpen(foremostHand);
			HandCallbacks(foremostHand);
		}
		m_handOpenLastFrame = m_handOpenThisFrame;
	}
}