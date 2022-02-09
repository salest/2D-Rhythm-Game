using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Variables")]
    public float moveSpeed = 25f;
    public float sprintSpeed = 35f;
    public float leftBoundary = -3.5f;
    public float rightBoundary = 3.5f;

    PlayerController playerController;

    //public GameObject[] positions;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    private void Update()
    {
        HandleMovement();
    }

    public void HandleMovement()
    {
        //Mouse Input Controls
        Vector3 move = new Vector3(playerController.projectedMousePos.x, transform.position.y, 0);
        transform.position = move;
        if (gameObject.transform.position.x <= leftBoundary)
        {
            gameObject.transform.position = new Vector3(leftBoundary, transform.position.y, 0);
        }
        if(gameObject.transform.position.x >= rightBoundary)
        {
            gameObject.transform.position = new Vector3(rightBoundary, transform.position.y, 0);
        }            

    }
}
