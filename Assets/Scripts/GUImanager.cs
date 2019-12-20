using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUImanager : MonoBehaviour {
	
	public void OnPlay(){
		SceneManager.LoadScene("GameScene");
	}

	public void Quit(){
		Debug.Log("QUIT!");
		Application.Quit();
	}

}
