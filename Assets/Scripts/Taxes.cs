using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taxes : MonoBehaviour, ICollectible
{
    public static event Action OnTaxCollected;
    public void Collect()
    {
        Debug.Log("Taxes");
        GameManager.Instance.configs.taxes++;
        Destroy(gameObject);
        OnTaxCollected?.Invoke();
    }
}
