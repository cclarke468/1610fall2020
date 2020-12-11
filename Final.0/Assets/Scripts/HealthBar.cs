using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class HealthBar : MonoBehaviour
{
    private Image o2Bar;
    public GlobalData globalData;
    private void Start()
    {
        o2Bar = GetComponent<Image>();
    }

     public void DisplayValue()
     {
         o2Bar.fillAmount = globalData.o2Percent;
         // need coroutine for slow decrease of O2
     }
     
}
