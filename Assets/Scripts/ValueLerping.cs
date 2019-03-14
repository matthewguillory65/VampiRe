using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueLerping : MonoBehaviour
{
    public int MinScale = 1;
    public int MaxScale = 3;
    public Vector3 ScaleSize;
    public float PercentToLerp = .50f;
	// Use this for initialization
    void Lerp(int Min, int Max, float percent)
    {
        // The high number minus the low number will give a value that will need to be multiplied by the percent value.
        Min = MinScale;
        Max = MaxScale;
        percent = PercentToLerp;
        float returnValue = (Max - Min) * percent;
        for (returnValue = 0; returnValue > 0; returnValue++)
        {
            gameObject.transform.localScale.Scale(ScaleSize);
        }
    }

    void WhenToLerp(Collider other)
    {
        // if the gameObject touches a object with the tag of Ground attached then the function lerp will be raised.
        if (other.gameObject.CompareTag("Ground"))
        {
            Lerp(MinScale,MaxScale,PercentToLerp);
        }
    }
    // Use this for initialization
    void Start()
    {

    }
	// Update is called once per frame
	void Update () {
		
	}
}
