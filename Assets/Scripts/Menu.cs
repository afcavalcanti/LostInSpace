using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public InputField input1;

	public void ChangeScene (string SceneName){

		SceneManager.LoadScene (SceneName);
	}
}
