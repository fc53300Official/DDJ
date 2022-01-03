using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public bool PlayerDeath;

    void FixedUpdate()
    {
        if (PlayerDeath == true)
        {
            transform.position = target.position + offset;
        }
       
        if (PlayerDeath == false)
        {
            transform.position = target.position + offset;
        }
    }
    
}
