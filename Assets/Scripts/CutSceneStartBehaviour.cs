using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneStartBehaviour : MonoBehaviour {
    
    public Camera playerCamera;
    public Camera cutSceneCamera;
    public GameObject cutScenePlayer;
    public GameEvent startCutScene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerCamera.enabled = false;
            cutSceneCamera.enabled = true;
            cutScenePlayer.SetActive(true);
            startCutScene.Raise();

        }
    }    // Use this for initialization
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerCamera.enabled = true;
            cutSceneCamera.enabled = false;
            cutScenePlayer.SetActive(false);
        }
    }
    void Start () {
        cutScenePlayer.SetActive(false);

	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}
}
