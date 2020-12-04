using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class HealthBar : MonoBehaviour
{
    private Image o2Bar;
    private void Start()
    {
        o2Bar = GetComponent<Image>();
    }

    // public void DisplayValue(FloatData data)
    // {
    //     o2Bar.fillAmount = data.value;
            //need coroutine for slow decrease of O2
    // }
}
