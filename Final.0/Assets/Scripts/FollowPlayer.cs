using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 location = new Vector3(8.4f, 4.9f, -62.7f);
    public Quaternion rotation = new Quaternion(-1.685f,0,0,0);

    private void Start()
    {
        location.Set(transform.position.x,transform.position.y, transform.position.z);
        // transform.rotation = rotation;
    }

    void LateUpdate()
    {
        // transform.Translate(player.transform.position);
        location.x = player.transform.position.x + 8.4f;
        location.y = transform.position.y;
        location.z = transform.position.z;
        transform.position = location;
        // print(transform.position + " camera position");
        // print(player.transform.position + " player position");
    }
}
