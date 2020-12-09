using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //this is to reference the vehicle/player in the game—drag and drop the vehicle into this slot in the inspector
    public GameObject player;
   
    //this part takes place after the **
    public Vector3 offset = new Vector3(0, 5, -9);
    void Update()
    {
        //--transform.position = player.transform.position;
        //we need to offset the camera behind player by adding to player position
        //"new" creates new instance (different from a variable) of a vector3; it is TEMPORARY!
        //--transform.position = player.transform.position + new Vector3(0, 5, -9);
        //**dang it...we're making a permanent variable for the new vector3 called offset
        transform.Translate(player.transform.position + offset);
    }
}
