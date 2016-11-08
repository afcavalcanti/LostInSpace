using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	public void ChangeScene (string SceneName){

		SceneManager.LoadScene (SceneName);
	}
}
