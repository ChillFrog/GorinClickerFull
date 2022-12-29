using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundsManager : MonoBehaviour
{
    [SerializeField] public Slider musicSlider;
    [SerializeField] public Slider soundSlider;
    [SerializeField] public AudioSource musicSource;
    [SerializeField] public AudioSource clickSource1;
    [SerializeField] public AudioSource clickSource2;
    [SerializeField] public AudioSource clickSource3;
    [SerializeField] public AudioSource clickSource4;
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicValue"))
        {
            PlayerPrefs.SetFloat("musicValue", 1);
            LoadMusic();
        }
        else
        {
            LoadMusic();
        }
        if (!PlayerPrefs.HasKey("soundValue"))
        {
            PlayerPrefs.SetFloat("soundValue", 1);
            LoadSound();
        }
        else
        {
            LoadSound();
        }
    }

    public void LoadMusic()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicValue");
    }
    public void LoadSound()
    {
        soundSlider.value = PlayerPrefs.GetFloat("soundValue");
    }

    public void ChangeSound()
    {
        clickSource1.volume = soundSlider.value;
        clickSource2.volume = soundSlider.value;
        clickSource3.volume = soundSlider.value;
        clickSource4.volume = soundSlider.value;
        SaveSound();
    }
    public void ChangeMusic()
    {
        musicSource.volume = musicSlider.value;
        Save();
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("musicValue", musicSlider.value);
    }
    public void SaveSound()
    {
        PlayerPrefs.SetFloat("soundValue", soundSlider.value);
    }
}
