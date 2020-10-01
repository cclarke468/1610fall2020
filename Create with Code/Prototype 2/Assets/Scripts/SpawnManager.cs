using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; 
    //new array of GameObjects
 
    void Update()
    {
        //to use to call the number of any object in the array
        int animalIndex = Random.Range(0,animalPrefabs.Length); 
        //Random is a class to call random numbers,
        //using a range (start number, number of items in range——can use the array itself)
       
        if (Input.GetKeyDown(KeyCode.S)) //on "s" button, do...
        {
            Instantiate(animalPrefabs[animalIndex], new Vector3(0,0,20), 
                animalPrefabs[animalIndex].transform.rotation);
            
            //this means create new game objects from the array of animal prefabs,
            //in the location z + 20 (so it's out of the player's view)
            //and summon each of those animals at the correct rotation
        }
    }
}
