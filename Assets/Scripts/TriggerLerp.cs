using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLerp : MonoBehaviour
{
    private GameObject Ground;
    public SoundLerp SoundToLerp;

    private void OnTriggerEnter(Collider other)
    {
        SoundToLerp.TriggerLerp.Subscribe(new GameEventListener());
        if (other.CompareTag("Ground") == true)
        {
            do
            {
                SoundToLerp.Invoke("RaiseEvent",5);
                Debug.Log("Should be Lerping.");
            }
            while (other.CompareTag("Ground")==true);
        }

        if (SoundToLerp.isLerping == true)
        {
            SoundToLerp.Invoke("RaiseEvent",5);
            Debug.Log("Should be Lerping.");
        }
    }

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
