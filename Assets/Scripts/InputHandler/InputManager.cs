using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager {
    private readonly string osInfo;

    public InputManager() {
        osInfo = SystemInfo.operatingSystem;
        Debug.Log(osInfo);
    }

    public enum InputType {
        KEYBOARD,
        CONTROLLER
    }
}
