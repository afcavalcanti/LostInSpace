using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public InputField input1;
	public InputField input2;

	public void ChangeScene (string SceneName){

		SceneManager.LoadScene (SceneName);
	}

	public void definirquantidade(){
	
		ObstacleGenerator.nObstaculos = float.Parse (input1.text);
	}

	public void definirvelocidade(){
	
		PlayerController.velocidade = float.Parse (input2.text);
	}
}
