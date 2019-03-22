using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkirtBehaviour : MonoBehaviour {
    public Renderer renderer;
    public Material materialGreen;

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
            ChangeColor();
        }
        print("collide");
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ChangeColor();
        }
    }
    public void ChangeColor()
    {
        if(renderer.material.color == Color.red)
        {
            renderer.material = materialGreen;
        }
        else
        {
            renderer.material.color = Color.red;
        }
    }


}
