
using System;
using UnityEngine;
using UnityEngine.Events;

public class UnityEvents : MonoBehaviour
{
   public UnityEvent myEvent;

   private void OnTriggerEnter(Collider other)
   {
      myEvent.Invoke();
      //invoke is a function to tell the event to run
      //sets GameObject setActive (in Unity Editor) to false
   }
}
