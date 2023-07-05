using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenMenu : MonoBehaviour
{
    //InputAction.CallbackContext context
    [Header("InputSystem")]
    [SerializeField] public static PlayerInputsAction playerControls;
    internal InputAction ClosePause;

    [SerializeField] private GameObject MenuCan, UI;

    private void Awake()
    {
        playerControls = new PlayerInputsAction();
    }
    private void OnEnable()
    {
        PlayerGroundMovement.pause.performed += PauseGame;
        ClosePause = playerControls.UI.Close;
        ClosePause.performed += UnPause;
    }
    private void OnDisable()
    {
        PlayerGroundMovement.pause.performed -= PauseGame;
        ClosePause.performed -= UnPause;
        ClosePause.Disable();
    }

    public void PauseGame(InputAction.CallbackContext context)
    {
        if (GameManager.Instance.configs.isDead)
        {
            return;
        }
        context.ReadValueAsButton();
        PlayerGroundMovement.playerControls.Ground.Disable();
        playerControls.UI.Enable();
        ClosePause.Enable();
        Debug.Log("Open");
        MenuCan.SetActive(true);
        Time.timeScale = 0;
        UI.SetActive(false);
    }
    public void UnPause(InputAction.CallbackContext context)
    {
        if (GameManager.Instance.configs.isDead)
        {
            return;
        }
        context.ReadValueAsButton();
        MenuCan.SetActive(false);
        UI.SetActive(true);
        Time.timeScale = 1;
        playerControls.UI.Disable();
        PlayerGroundMovement.playerControls.Ground.Enable();
        Debug.Log("Close");
        ClosePause.Disable();
    }
}
