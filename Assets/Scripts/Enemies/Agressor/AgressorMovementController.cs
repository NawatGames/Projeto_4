using System;
using Movement_System;
using UnityEngine;

namespace Enemies.Agressor {
    [RequireComponent(typeof(CharacterMovementHandler))]
    public class AgressorMovementController : MonoBehaviour {
        [SerializeField] private float _maxSpeed;
        private BoxCollider2D _collider2D;
        private CharacterMovementHandler _movementHandler;
        private Vector2 _currentDirection = Vector2.right;
        private float _currentSpeed;

        private void Awake() {
            _movementHandler = GetComponent<CharacterMovementHandler>();
            _collider2D = GetComponent<BoxCollider2D>();
            _currentSpeed = _maxSpeed;
        }

        private void Update() {
            _movementHandler.Move(_currentDirection, _currentSpeed);

            if (!CheckIfTheresFloorAhead()) {
                _currentDirection *= -1;
            }
        }

        private bool CheckIfTheresFloorAhead() {
            return Physics2D.Raycast(transform.position + new Vector3((_currentDirection.x* (_collider2D.size.x / 2)),0,0), Vector2.down);
        }

        private void OnDrawGizmos() {
            if(Application.isPlaying)
                Gizmos.DrawRay(transform.position + new Vector3((_currentDirection.x* (_collider2D.size.x / 2)),0,0), Vector2.down);
        }
    }
}