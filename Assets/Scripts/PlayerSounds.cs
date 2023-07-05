using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSounds : MonoBehaviour
{ 
    public AudioClip jSound;

    public AudioSource source;

    private void OnEnable()
    {
        if(PlayerGroundMovement.jump != null)
        {
            PlayerGroundMovement.jump.performed += JumpSound;
        }
    }
    private void OnDisable()
    {
        if (PlayerGroundMovement.jump != null)
        {
            PlayerGroundMovement.jump.performed -= JumpSound;
        }

    }

    public void JumpSound(InputAction.CallbackContext context)
    {
        context.ReadValueAsButton();
        AudioManager.Instance.PlaySoundCHECKRandom(jSound, 0.9f, 1.1f, source);
    }

}
