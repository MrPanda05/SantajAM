using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [SerializeField] int sceneId;
    public static event Action OnPortalHit;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnPortalHit?.Invoke();
            GameManager.Instance.SaveStats();
            SceneManager.LoadScene(sceneId);
        }
    }

}
