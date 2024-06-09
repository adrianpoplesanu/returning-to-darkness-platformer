using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {
    private InputManager inputManager;
    private Dictionary<string, string> keysMapping;

    void Start() {
        inputManager = new InputManager();
    }

    void Update() {
        
    }
}
