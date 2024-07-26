using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {
    private InputManagerCustom inputManagerCustom;
    private Dictionary<string, string> keyboardMapping;
    private Dictionary<string, string> controllerMapping;
    public Vector2 movementValues;
    public string controllerId;

    void Start() {
        inputManagerCustom = new InputManagerCustom();
    }

    public bool IsXBOXController() {
        return inputManagerCustom.IsXBOXController(controllerId);
    }

    public Vector2 GetStickMovement() {
        if (controllerId.Contains("keyboard")) {
            movementValues.x = Input.GetAxisRaw("Horizontal");
            movementValues.y = Input.GetAxisRaw("Vertical");
        } else if (controllerId.Contains("controller")) {
            movementValues.x = Input.GetAxisRaw("Horizontal"); // TODO: these might be different mappings
            movementValues.y = Input.GetAxisRaw("Vertical"); // TODO: these might be different mappings
        } else {
            Debug.LogError("Unknown controller type used");
        }
        return movementValues;
    }

    public bool JumpPressed() {
        if (controllerId.Contains("keyboard")) {
            return Input.GetKeyDown(KeyCode.Space);
        }
        return false;
    }
}
