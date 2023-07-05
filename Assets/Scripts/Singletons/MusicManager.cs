using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance;
    private AudioSource musicSource;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.Log("Destroying duplicate of music manager");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Setting music manager");
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        musicSource = GetComponent<AudioSource>();
    }
    public void ChangeMusic(AudioClip music)
    {
        musicSource.PlayOneShot(music);
    }
    public void StopMusic()
    {
        musicSource.Stop();
    }
    public void PlayMusic()
    {
        musicSource.Play();
    }
}
