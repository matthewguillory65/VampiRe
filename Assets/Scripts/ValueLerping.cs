using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class ValueLerping : MonoBehaviour
{
    public Vector3 MinScale;
    public Vector3 MaxScale;

    public bool Repeatable;
    public float speed = 3f;
    public float duration = 5f;
  
	// Use this for initialization
	IEnumerator  Start ()
    {
        MinScale = transform.localScale;
        while (Repeatable)
        {
            return RepeatLerp(MinScale, MaxScale);
        }
        return RepeatLerp(MinScale, MaxScale);
    }

    public IEnumerator RepeatLerp(Vector3 a, Vector3 b)
    {
        float i = 0.0f;
        float rate = (1.0f / duration) * speed;
        while (i<1.0f)
        {
            i += Time.deltaTime * rate;
            transform.localScale=Vector3.Lerp(a,b,5);
            return null;
        }
        return null;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
