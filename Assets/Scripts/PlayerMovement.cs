using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float maxSpeed = 0f;
    public Transform player;
    public Rigidbody2D move;
    public float rotationSpeed = 0f;

    // Use this for initialization


    void Start()
    {
        GameObject go = GameObject.Find("Player");
        move = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveUpDown = Input.GetAxis("Vertical");
        move.velocity = new Vector2(moveUpDown * maxSpeed * Time.deltaTime, move.velocity.y);

        float moveRightLeft = Input.GetAxis("Horizontal");
        move.velocity = new Vector2(moveRightLeft * maxSpeed * Time.deltaTime, move.velocity.x);


    }
}
