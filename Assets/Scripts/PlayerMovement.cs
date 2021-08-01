using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameUtility;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    public Transform player_transform;
    private Vector2 original_position;
    private void Start()
    {
        original_position = player_transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;



        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            // Resets player's position and speed
            player_transform.position = original_position;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
