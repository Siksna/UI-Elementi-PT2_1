using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinasParsledzejs : MonoBehaviour {

	// Use this for initialization
	public void UzSakumu(){
		SceneManager.LoadScene ("Sakums", LoadSceneMode.Single);
	}

	public void UzBinaAinu(){
		SceneManager.LoadScene (1, LoadSceneMode.Single);
	}

	public void Apturet(){
		Application.Quit();
	}
}
