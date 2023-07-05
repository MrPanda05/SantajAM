using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    //Handles player death
    private Rigidbody2D rg;

    public AudioClip explosion;

    public GameObject prefab;

    public static event Action OnPlayerDeath;

    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        KillPlayer.OnPlayerHit += Kill;
    }
    private void OnDisable()
    {
        KillPlayer.OnPlayerHit -= Kill;
    }
    //Kill The player
    public void Kill()
    {
        StartCoroutine(KillCourou());//This is so we can wait for seconds
    }
    //Kill player couroutine
    IEnumerator KillCourou()
    {
        GameManager.Instance.configs.isDead = true;
        GameManager.Instance.configs.lives--;
        PlayerGroundMovement.playerControls.Disable();
        OpenMenu.playerControls.Enable();
        OpenMenu.playerControls.UI.Enable();
        gameObject.GetComponent<PlayerSounds>().enabled = false;
        rg.velocity = Vector2.zero;
        rg.gravityScale = 0;
        rg.isKinematic = true;
        //gameObject.GetComponentInChildren<KillPlayer>().enabled = false;
        gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
        AudioManager.Instance.PlaySoundNOCHECK(explosion);
        Instantiate(prefab, transform.position, Quaternion.identity);
        yield return new WaitForSecondsRealtime(1.3f);
        OnPlayerDeath?.Invoke();
    }

    
}
