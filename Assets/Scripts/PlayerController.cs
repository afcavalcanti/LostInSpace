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
		float rotacao = 2f;
		float velocidade = 20f;

		translacao *= Time.deltaTime;
		profundidade *= Time.deltaTime;
		rotacao *= Time.deltaTime;

		transform.Translate (translacao * velocidade, 0, profundidade * velocidade);

		if(Input.GetKey(KeyCode.Keypad8))
			transform.Rotate (rotacao * velocidade, 0, 0);
		if(Input.GetKey(KeyCode.Keypad5))
			transform.Rotate (-rotacao * velocidade, 0, 0);
		if(Input.GetKey(KeyCode.Keypad4))
			transform.Rotate (0, 0, rotacao * velocidade);
		if(Input.GetKey(KeyCode.Keypad6))
			transform.Rotate (0, 0, -rotacao * velocidade);
	}
}