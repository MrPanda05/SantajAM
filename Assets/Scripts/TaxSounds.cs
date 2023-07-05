using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxSounds : MonoBehaviour
{
    public AudioClip taxSound;

    public AudioSource source;

    private void OnEnable()
    {
        Taxes.OnTaxCollected += PlayTaxSound;
    }
    private void OnDisable()
    {
        Taxes.OnTaxCollected -= PlayTaxSound;
    }

    public void PlayTaxSound()
    {
        AudioManager.Instance.PlaySoundCHECK(taxSound, source);
    }
}
