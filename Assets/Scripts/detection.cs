using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detection : MonoBehaviour
{
    public Transform player;
    public float angleOfView;
    public float distanceOfView;
    RaycastHit hit;
    public bool ICanSeeThePlayer = false;

    // Update is called once per frame
    void Update()
    {
        var targetDir = player.position - transform.position;
        float angle = Vector3.Angle(targetDir, transform.forward);
        float distance = Vector3.Distance(player.position, transform.position);
        print(distance + ": between player and npc");
        if (angle <= angleOfView && distance <= distanceOfView)
        {
            Debug.DrawLine(transform.position, player.transform.position, Color.blue);
            if (Physics.Linecast(transform.position, player.transform.position, out hit))
            {
                if(hit.collider.CompareTag("Player"))
                {
                    print("NPC can see player");
                    ICanSeeThePlayer = true;
                }
                else
                {
                    ICanSeeThePlayer = false;
                }
            }
        }
    }
}
