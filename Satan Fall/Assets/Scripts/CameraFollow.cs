using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public float FollowSpeed = 2f;
    public Transform target;


    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3(transform.position.x, target.position.y+2.5f, transform.position.z);
        transform.position = targetPos;
    }
}
