using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSFX : MonoBehaviour {

    public AudioMixer mixer;

    public Slider slider;

    void Start(){
        slider.value = PlayerPrefs.GetFloat("MusicSFX", 0f);
    }

    public void SetLevel (float sliderValue){
    	mixer.SetFloat("volSFX", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicSFX", sliderValue);
    }
}