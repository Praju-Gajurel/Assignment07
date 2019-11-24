using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderScript : MonoBehaviour
{
    public Slider MySlider;
    public Text SliderValue;

    void Update()
    {
        SliderValue.text = MySlider.value.ToString("f2"); // float with two decimals
    }
}
