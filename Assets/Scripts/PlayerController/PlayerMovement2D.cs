using System;
using System.Collections;
using System.Collections.Generic;
using PlayerStateMachineSystem;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    public Rigidbody2D body2D;
    [SerializeField] private PlayerStateController machine;
    [SerializeField] private float _walkSpeed;

    // Start is called before the first frame update
    void Start()
    {
        body2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate()
    {

    }

    public void Idle()
    {
        body2D.velocity = new Vector2(0f, body2D.velocity.y);

    }
    public void Ground()
    {
        body2D.velocity = new Vector2(body2D.velocity.x, 0f);
    }
    public void Jump()
    {
        body2D.AddForce(new Vector2(0f, 20f), ForceMode2D.Impulse);
    }
    public void Run()
    {
        body2D.velocity = new Vector2(_walkSpeed * machine.movementInput.x, body2D.velocity.y);
    }
}
