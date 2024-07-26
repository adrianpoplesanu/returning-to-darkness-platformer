using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputController))]
public class PlayerMovement : MonoBehaviour
{
    private InputController inputController;
    void Start() {
        inputController = GetComponent<InputController>();
    }
    void Update() {
        Debug.Log(inputController.GetStickMovement());
    }
}
