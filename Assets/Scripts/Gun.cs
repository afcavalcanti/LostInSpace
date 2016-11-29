using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public GameObject prefab;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)) {
			GameObject projectile = Instantiate (prefab) as GameObject;
			projectile.transform.position = transform.position + Camera.main.transform.forward * 4f;
			Rigidbody rb = projectile.GetComponent<Rigidbody> ();
			rb.velocity = Camera.main.transform.forward * 40;
		}
	}
}
