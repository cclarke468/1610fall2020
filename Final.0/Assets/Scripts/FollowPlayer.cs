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
        transform.position = location;
        // transform.rotation = rotation;
    }

    void LateUpdate()
    {
        // transform.Translate(player.transform.position);
        transform.position = player.transform.position + location;
        print(transform.position + " camera position");
        print(player.transform.position + " player position");
    }
}
