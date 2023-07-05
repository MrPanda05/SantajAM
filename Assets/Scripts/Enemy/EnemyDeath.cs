using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    //Handles enemy death
    public GameObject collision, headCollision;

    public Sprite deathSprite;

   public IEnumerator Kill()
    {
        Destroy(collision);
        Destroy(headCollision);
        var Sprite = GetComponentInChildren<SpriteRenderer>();
        Sprite.sprite = deathSprite;
        yield return new WaitForSecondsRealtime(0.5f);
        Destroy(gameObject);
    }
}
