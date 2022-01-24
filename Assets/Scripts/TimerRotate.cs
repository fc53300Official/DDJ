using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerRotate : MonoBehaviour
{
    public void flip()
    {
        transform.Rotate(0f, 180f, 0f);
    }
}
