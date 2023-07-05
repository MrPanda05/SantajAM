using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerStats : ScriptableObject
{
    [Header("Volume")]
    [Range(-80f, 20f)] public int MasterVolume;
    [Range(-80f, 20f)] public int MusicVolume;
    [Range(-80f, 20f)] public int SoundVolume;
    public int Score;
    public int HighScore;
    public int lives;
    public int taxes;
    public int maxTaxes;
    public Vector2 spawnloacation;
    public bool isDead;
    public int checkpoint;

    public bool isPaused;

}
