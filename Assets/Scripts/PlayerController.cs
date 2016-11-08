using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		float translacao = Input.GetAxis ("Horizontal");
		float profundidade = Input.GetAxis ("Vertical");
		transform.Rotate (profundidade, 0, translacao);
		transform.Translate (0, 0, 1f);
	}
}