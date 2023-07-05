using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    private AudioSource audioSource;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.Log("Destroying duplicate of audio manager");
            Destroy(this);
        }
        else
        {
            Debug.Log("Setting audio manager");
            Instance = this;
        }
        audioSource = GetComponent<AudioSource>();
    }
    
    /// <summary>
    /// Plays sound if none is currently playing, if it is stop execution
    /// </summary>
    /// <param name="sound"></param>
    public void PlaySoundCHECK(AudioClip sound, AudioSource source = null)
    {
        if(source == null)
        {

            if (audioSource.isPlaying)
            {
                return;
            }
            else
            {
                audioSource.PlayOneShot(sound);
            }
        }
        else
        {
            if (source.isPlaying)
            {
                return;
            }
            else
            {
                source.PlayOneShot(sound);
            }
        }
    }
    /// <summary>
    /// Plays sound if none is currently playing, if it is stop execution. Play at a certain pitch
    /// </summary>
    /// <param name="sound"></param>
    /// <param name="pitch"></param>
    public void PlaySoundCHECKPITCH(AudioClip sound, float pitch, AudioSource source = null)
    {
        if(source == null)
        {
            if (audioSource.isPlaying)
            {
                return;
            }
            else
            {
                audioSource.pitch = pitch;
                audioSource.PlayOneShot(sound);
            }
        }
        else
        {
            if (source.isPlaying)
            {
                return;
            }
            else
            {
                source.pitch = pitch;
                source.PlayOneShot(sound);
            }
        }
    }

    /// <summary>
    /// Plays sound if none is currently playing, if it is stop execution. Play at a random pitch
    /// </summary>
    /// <param name="sound"></param>
    /// <param name="max"></param>
    /// <param name="min"></param>
    public void PlaySoundCHECKRandom(AudioClip sound, float min, float max, AudioSource source = null)
    {
        if(source == null)
        {

            if (audioSource.isPlaying)
            {
                return;
            }
            else
            {
                audioSource.pitch = Random.Range(min, max);
                audioSource.PlayOneShot(sound);
            }
        }
        else
        {
            if (source.isPlaying)
            {
                return;
            }
            else
            {
                source.pitch = Random.Range(min, max);
                source.PlayOneShot(sound);
            }
        }
    }

    /// <summary>
    /// Plays sound independent if one is playing
    /// </summary>
    /// <param name="sound"></param>
    public void PlaySoundNOCHECK(AudioClip sound, AudioSource source = null)
    {
        if(source == null)
        {
            audioSource.PlayOneShot(sound);
        }
        else
        {
            source.PlayOneShot(sound);
        }
    }

    /// <summary>
    /// Plays sound idependent if one is playing and set its pitch
    /// </summary>
    /// <param name="sound"></param>
    /// <param name="pitch"></param>
    public void PlaySoundNOCHECKPITCH(AudioClip sound, float pitch)
    {
        audioSource.pitch = pitch;
        audioSource.PlayOneShot(sound);
    }

    /// <summary>
    /// Plays sound idependent if one is playing and set a random pitch
    /// </summary>
    /// <param name="sound"></param>
    /// <param name="min"></param>
    /// <param name="max"></param>
    public void PlaySoundNOCHECKRandom(AudioClip sound, float min, float max)
    {
        audioSource.pitch = Random.Range(min, max);
        audioSource.PlayOneShot(sound);
    }

}
