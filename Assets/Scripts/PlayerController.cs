using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public static float velocidade;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Fim.terminou)
            return;
		
		float translacao = Input.GetAxis("Horizontal") * velocidade; //move o objeto na horizontal de acordo com o input
        float profundidade = 1f * velocidade; //mantem o objeto seguindo em frente

        translacao *= Time.deltaTime;
        profundidade *= Time.deltaTime;
        transform.Translate(profundidade, 0, -translacao); //a translação é feita no eixo z que cresce para esquerda, portanto o valor deve ser negativo
	}
}
