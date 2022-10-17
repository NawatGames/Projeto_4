using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementHandler : MonoBehaviour
{
    [SerializeField] private Transform root;
    [SerializeField] private new Rigidbody2D rigidbody2D;

    public void Move(Vector2 direction, float speed)
    {
        root.position = (Vector3) direction * (speed * Time.deltaTime) + root.position;
    }

    public void Jump(Vector2 velocity)
    {
        rigidbody2D.velocity = velocity;
    }


}
