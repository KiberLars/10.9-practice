using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement : MonoBehaviour
{
    private float minPosZ = -4f;
    private float maxPosZ = 0f;

    public bool isLeft = true;
    private void Update()
    {
        if ( isLeft)
        {
            if (transform.position.z > minPosZ)
            {
                float needZ = transform.position.z - 0.01f;
                transform.position = Vector3.MoveTowards(transform.position,
                    new Vector3(transform.position.x, transform.position.y, needZ),
                    Time.deltaTime);
            }
            else
            {
                isLeft = false;
            }
        }
        else
        {
            if (transform.position.z < maxPosZ)
            {
                float needZ = transform.position.z + 0.01f;
                transform.position = Vector3.MoveTowards(transform.position,
                    new Vector3(transform.position.x, transform.position.y, needZ),
                    Time.deltaTime);
            }
            else
            {
                isLeft = true;
            }
        }
        
    }
}
