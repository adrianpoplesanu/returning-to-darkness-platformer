using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagerCustom {
    private readonly string osInfo;
    private InputMapping inputMapping;

    public InputManagerCustom() {
        osInfo = SystemInfo.operatingSystem;
        inputMapping = new InputMapping();
        Debug.Log(osInfo);
    }

    public bool IsMacOs() {
        return osInfo.Contains("Mac OS");
    }

    public bool IsWindows() {
        return osInfo.Contains("Windows");
    }

    public bool IsLinux() {
        return osInfo.Contains("Linux");
    }

    public bool IsXBOXController(string joystickName) {
        return joystickName.ToLower().Contains("xbox");
    }

    public enum InputType {
        KEYBOARD,
        CONTROLLER
    }
}
