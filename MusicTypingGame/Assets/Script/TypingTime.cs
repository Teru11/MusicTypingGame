using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingTime : MonoBehaviour {

    Slider typingTimeSlider;
    public float sliderSpeed = 0.05f;
    TypeObject typeObjectScript;
	// Use this for initialization
	void Start () {
        typingTimeSlider = GetComponent <Slider>();
        typeObjectScript = FindObjectOfType<TypeObject>();
	}
	
	// Update is called once per frame
	void Update () {
        typingTimeSlider.value += sliderSpeed;

        if(typingTimeSlider.value == typingTimeSlider.maxValue)
        {
            SliderUpdate();
            typeObjectScript.compulsionEnd = true;
        }
	}

    public void SliderUpdate()
    {
        typingTimeSlider.value = 0;
    }

}
