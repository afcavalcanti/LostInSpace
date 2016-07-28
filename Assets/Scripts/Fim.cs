using UnityEngine;
using System.Collections;

public class Fim : MonoBehaviour {

	public static bool terminou = false;

    void OnTriggerEnter(Collider Other) {

		terminou = true;
    }
}
