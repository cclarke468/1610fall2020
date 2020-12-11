using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Collection : ScriptableObject
{
    public List<GameObject> collectedObjects;
    public void Collect(GameObject obj)
    {
        collectedObjects.Add(obj);
    }

    public void PrintCollection()
    {
        foreach (var obj in collectedObjects)
        {
            Debug.Log(obj+ " ");
        }
    }

    void Start()
    {
        collectedObjects.Clear();
    }
}
