using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputHandler))]
[RequireComponent(typeof(PlayerSettings))]
public class InputController : MonoBehaviour
{
    private InputHandler inputHandler;
    private PlayerSettings playerSettings;
    private string controllerId;
    void Start() {
        inputHandler = GetComponent<InputHandler>();
        playerSettings = GetComponent<PlayerSettings>();
        controllerId = ((InputManagerCustom.InputType) playerSettings.inputType).ToString().ToLower();
        inputHandler.controllerId = controllerId;
        Debug.Log(controllerId);
    }

   public  Vector2 GetStickMovement() {
        Vector2 movement = inputHandler.GetStickMovement();
        return movement;
    }

    public bool JumpPressed() {
        bool result = inputHandler.JumpPressed();
        return result;
    }

    public bool StayPressed() {
        return false;
    }

    public bool ComePressed() {
        return false;
    }
}
