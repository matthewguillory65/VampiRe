using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkirtBehaviour : MonoBehaviour {
    public GameEvent OnCaughtEvent;
    public GameEvent OnNotCaughtEvent;
    public Renderer renderer;

    // Use this for initialization
    
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
 
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            OnCaughtEvent.Raise();
        }
        print("collide");
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            OnNotCaughtEvent.Raise();
        }
    }
    public void ChangeColor()
    {
        if(renderer.material.color == Color.red)
        {
            renderer.material.color = Color.green;
        }
        else
        {
            renderer.material.color = Color.red;
        }
    }


}
