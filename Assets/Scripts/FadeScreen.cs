using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScreen : MonoBehaviour
{
    [SerializeField] private Animator anim;

    private void Awake()
    {
        if(anim == null)
        {
            anim.GetComponent<Animator>();
        }
    }
    private void Start()
    {
        StartCoroutine(FadeOut());
    }

    private void OnEnable()
    {
        Portal.OnPortalHit += GoFade;
    }
    private void OnDisable()
    {
        Portal.OnPortalHit -= GoFade;
    }
    public IEnumerator FadeIn()
    {
        gameObject.transform.parent.gameObject.SetActive(true);
        anim.Play("FadeIn");
        yield return new WaitForSecondsRealtime(4f);

    }
    public IEnumerator FadeOut()
    {
        anim.Play("FadeOut");
        yield return new WaitForSecondsRealtime(5);
        gameObject.transform.parent.gameObject.SetActive(false);
    }
    public void GoFade()
    {
        StartCoroutine(FadeIn());
    }
}
