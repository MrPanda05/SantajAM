using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class VolumeMethods : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Slider masterSlider, SFXslider, musicSlider;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("SFX"))
        {
            PlayerPrefs.SetInt("SFX", -40);
        }
        else
        {
            SFXslider.value = PlayerPrefs.GetInt("SFX");
        }
        if (!PlayerPrefs.HasKey("Music"))
        {
            PlayerPrefs.SetInt("Music", -40);
        }
        else
        {
            musicSlider.value = PlayerPrefs.GetInt("Music");
        }
        if (!PlayerPrefs.HasKey("Master"))
        {
            PlayerPrefs.SetInt("Master", -40);
        }
        else
        {
            masterSlider.value = PlayerPrefs.GetInt("Master");
        }
    }

    public void SetSFXvolume()
    {
        GameManager.Instance.configs.SoundVolume = (int)SFXslider.value;
        PlayerPrefs.SetInt("SFX", GameManager.Instance.configs.SoundVolume);
        mixer.SetFloat("SFX", PlayerPrefs.GetInt("SFX"));
    }
    public void SetMusicVolume()
    {
        GameManager.Instance.configs.MusicVolume = (int)musicSlider.value;
        PlayerPrefs.SetInt("Music", GameManager.Instance.configs.MusicVolume);
        mixer.SetFloat("Music", PlayerPrefs.GetInt("Music"));
    }
    public void SetMasterVolume()
    {
        GameManager.Instance.configs.MasterVolume = (int)masterSlider.value;
        PlayerPrefs.SetInt("Master", GameManager.Instance.configs.MasterVolume);
        mixer.SetFloat("Master", PlayerPrefs.GetInt("Master"));
    }
}
