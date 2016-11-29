using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObstacleGenerator : MonoBehaviour {

    public GameObject asteroid;
	public GameObject astronauta;
	// Use this for initialization
	void Start () {

        for (int i = 0; i < 400; i++){
			Instantiate(asteroid, new Vector3(Random.Range(100f, -100f), Random.Range(100f, -100f), Random.Range(100f, -100f)), Quaternion.identity);
        }

		for (int i=0; i<3; i++){
			Instantiate(astronauta, new Vector3(Random.Range(100f, -100f), Random.Range(100f, -100f), Random.Range(100f, -100f)), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
