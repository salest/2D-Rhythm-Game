using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    //Movement Variables
    public float movementInputX;

    [Header("Movement Flags")]
    public bool movementPressed;
    public bool sprintPressed;

    PlayerInput playerInput;
    PlayerInputActions playerInputActions;

    [Header("Key Input Flags")]
    public bool button1_flag;
    public bool button2_flag;
    public bool button3_flag;
    public bool button4_flag;
    public bool jumpButton_flag;

    public float mousePos;
    public Vector3 projectedMousePos;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        playerInputActions = new PlayerInputActions();

        playerInputActions.PlayerAction.Enable();


        //Key Input
        //playerInputActions.KeyCommands.Button1.performed += ctx => button1_flag = ctx.ReadValueAsButton();
        //playerInputActions.KeyCommands.Button2.performed += ctx => button2_flag = ctx.ReadValueAsButton();
        //playerInputActions.KeyCommands.Button3.performed += ctx => button3_flag = ctx.ReadValueAsButton();
        //playerInputActions.KeyCommands.Button4.performed += ctx => button4_flag = ctx.ReadValueAsButton();


        //WASD Movement Actions
        //playerInputActions.PlayerAction.Move.performed += ctx =>
        //{
        //    movementInputX = ctx.ReadValue<Vector2>().x;
        //    movementPressed = movementInputX != 0;
        //};

        playerInputActions.PlayerAction.Jump.performed += ctx => jumpButton_flag = ctx.ReadValueAsButton();

        playerInputActions.PlayerAction.Sprint.started += ctx => sprintPressed = true;
        playerInputActions.PlayerAction.Sprint.canceled += ctx => sprintPressed = false;

    }

    private void Update()
    {
        if (SongManager.instance.songEnded) return;
        mousePos = Mouse.current.position.ReadValue().x;
        projectedMousePos = mainCamera.ScreenToWorldPoint(new Vector3(mousePos, 0, 0));
    }

    public void SwitchCurrentActionMap(string actionMap)
    {
        playerInput.SwitchCurrentActionMap(actionMap);
    }
}
