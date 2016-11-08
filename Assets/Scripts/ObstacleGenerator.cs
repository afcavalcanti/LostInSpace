using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObstacleGenerator : MonoBehaviour {

    public GameObject cometa1;
	public GameObject cometa2;
	public GameObject cometa3;
	public GameObject cometa4;
	public GameObject cometa5;
	public GameObject cometa6;
	public GameObject cometa7;
	public GameObject astronauta;

	// Use this for initialization
	void Start () {

        for (int i = 0; i < 200; i++)
        {
            //faz n copias dentro do intervalo definido na funcao random
			Instantiate(cometa1, new Vector3(Random.Range(250f, -250f), Random.Range(250f, -250f), Random.Range(250f, -250f)), Quaternion.identity);
			Instantiate(cometa2, new Vector3(Random.Range(250f, -250f), Random.Range(250f, -250f), Random.Range(250f, -250f)), Quaternion.identity);
			Instantiate(cometa3, new Vector3(Random.Range(250f, -250f), Random.Range(250f, -250f), Random.Range(250f, -250f)), Quaternion.identity);
			Instantiate(cometa4, new Vector3(Random.Range(250f, -250f), Random.Range(250f, -250f), Random.Range(250f, -250f)), Quaternion.identity);
			Instantiate(cometa5, new Vector3(Random.Range(250f, -250f), Random.Range(250f, -250f), Random.Range(250f, -250f)), Quaternion.identity);
			Instantiate(cometa6, new Vector3(Random.Range(250f, -250f), Random.Range(250f, -250f), Random.Range(250f, -250f)), Quaternion.identity);
			Instantiate(cometa7, new Vector3(Random.Range(250f, -250f), Random.Range(250f, -250f), Random.Range(250f, -250f)), Quaternion.identity);
        }

		for (int i=0; i<3; i++){
			Instantiate(astronauta, new Vector3(Random.Range(250f, -250f), Random.Range(250f, -250f), Random.Range(250f, -250f)), Quaternion.identity);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
