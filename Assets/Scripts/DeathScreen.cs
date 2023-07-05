using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    [SerializeField] private GameObject UI;
    private void OnEnable()
    {
        UI.SetActive(false);
        StartCoroutine(RestartScene());
    }

    IEnumerator RestartScene()
    {
        //Add reset of taxes;
        yield return new WaitForSecondsRealtime(2f);
        GameManager.Instance.SoftResetPlayerStats();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
