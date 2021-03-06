﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Volume : MonoBehaviour {

    public AudioMixer mixer;

    public Slider slider;

    void Start(){
        slider.value = PlayerPrefs.GetFloat("MusicBGM", 0f);
    }

    public void SetLevel (float sliderValue){
    	mixer.SetFloat("volBGM", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicBGM", sliderValue);
    }
}