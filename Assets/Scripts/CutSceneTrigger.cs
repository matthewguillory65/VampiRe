using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]

public class CutSceneTrigger : MonoBehaviour {
  
    public Camera PlayerCamera;//drag and drop the camera of the player.
    public Camera CutSceneCamera;// Drag and drop the camera used for the cutscene.
    public GameEvent CutScene;
    public GameObject VideoPlayer;
    public int timetostop;
    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            VideoPlayer.SetActive(true);
            Destroy(VideoPlayer, timetostop);
            Debug.Log("CutScene Triggered");
        }
    }

    // Use this for initialization
    void Start () {

        VideoPlayer.SetActive(false);
        
	}
	
	// Update is called once per frame
	void Update () {
       
	}
}
