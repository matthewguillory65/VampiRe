using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoaderBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1, UnityEngine.SceneManagement.LoadSceneMode.Additive);
	}
 
}
