using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Astronauta : MonoBehaviour {

	public static float cont;

	void OnTriggerEnter (Collider other)
	{
		Destroy (other.gameObject);
	}
}
