using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fim : MonoBehaviour {

	public static bool terminou = false;

    void OnTriggerEnter (Collider Other) {

		terminou = true;
		SceneManager.LoadScene ("Restart");
    }
}
