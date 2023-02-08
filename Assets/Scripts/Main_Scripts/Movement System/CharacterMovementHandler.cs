using UnityEngine;
using UnityEngine.Events;

namespace Movement_System
{
    public class CharacterMovementHandler : MonoBehaviour
    {
        [SerializeField] private Transform root;
        [SerializeField] private new Rigidbody2D rigidbody2D;
        public bool canMove { get; set; }

        public UnityEvent characterJumpedEvent;

        public void Move(Vector2 direction, float speed)
        {
            if (canMove == true)
            {
                root.position = (Vector3) direction * (speed * Time.deltaTime) + root.position;
            }
        }

        public void Jump(Vector2 velocity)
        {
            rigidbody2D.velocity += velocity;
            characterJumpedEvent.Invoke();
        }
        
        
    }
}