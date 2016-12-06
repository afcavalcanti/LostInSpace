using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Astronauta : MonoBehaviour {

	private float cont=0;

	void OnTriggerEnter (Collider other)
	{
		Destroy (other.gameObject);
		cont = cont + 1;
	}

	void update(){
		if(cont==1)
			SceneManager.LoadScene ("Restart");
	}
}
