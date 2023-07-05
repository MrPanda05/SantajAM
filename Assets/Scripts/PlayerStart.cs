using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStart : MonoBehaviour
{
    //Class that is started everytime the player is spawn, and handles reset of taxes and set its default isDead var
    //Will change this so it will be used for the first time on the scene before the first
    private void Start()
    {
        gameObject.transform.position = GameManager.Instance.configs.spawnloacation;
        GameManager.Instance.configs.isDead = false;
        GameManager.Instance.configs.Score = 000;
    }

}
