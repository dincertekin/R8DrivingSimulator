using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

	void Start() {

	}

	void Update() {
		
	}

	public void PlayGame() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void QuitGame() {
		Debug.Log("Quit callback");
		Application.Quit();
	}

}
