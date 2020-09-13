using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPowerUp : MonoBehaviour
{
    public int ammo;
    private void OnTriggerEnter(Collider other)
    {
        ammo++;
        print(ammo);
    }
}
