using Movement_System;
using UnityEngine;

namespace Enemies.Agressor {
    [RequireComponent(typeof(CharacterMovementHandler))]
    public class AgressorMovementController : MonoBehaviour {
        [SerializeField] private float _speedPatrolMode;
        [SerializeField] private float _speedChaseMode;
        [SerializeField] private float _visionDistance;

        [SerializeField] private BoxCollider2D _collider2D;
        private CharacterMovementHandler _movementHandler;
        private Vector2 _currentDirection = Vector2.right;
        private float _currentSpeed;

        private void Awake() {
            _movementHandler = GetComponent<CharacterMovementHandler>();
            _currentSpeed = _speedPatrolMode;
        }

        private void Update() {
            _movementHandler.Move(_currentDirection, _currentSpeed);

            if (!CheckIfTheresFloorAhead() || CheckIfTheresAWallAhead()) {
                _currentDirection *= -1;
            }

            if (CheckIfPlayerIsAhead()) {
                print("Puta que me pariu. Que susto! O player tá aqui!");
                _currentSpeed = _speedChaseMode;
            }
            else {
                _currentSpeed = _speedPatrolMode;
            }
        }

        private bool CheckIfPlayerIsAhead() {
            var hit = CheckAhead();
            
            if(hit)
                return hit.transform.CompareTag("Player");
            return false;
        }
        
        private bool CheckIfTheresAWallAhead() {
            var hit = CheckAhead();
            var hitDistance = hit?Vector2.Distance(transform.position, hit.transform.position):Mathf.Infinity;
            if(hit)
                return !hit.transform.CompareTag("Player") && hitDistance <= _collider2D.size.x+0.5f;
            return false;
        }

        private bool CheckIfTheresFloorAhead() {
            return Physics2D.Raycast(transform.position + new Vector3((_currentDirection.x* (_collider2D.size.x / 2)),0,0), Vector2.down, 1f);
        }
        
        private RaycastHit2D CheckAhead() {
            return Physics2D.Raycast(transform.position + new Vector3((_currentDirection.x* (_collider2D.size.x / 2)),0,0), _currentDirection, _visionDistance);
        }

        private void OnDrawGizmos() {
            if(Application.isPlaying) {
                Gizmos.DrawRay(transform.position + new Vector3((_currentDirection.x * (_collider2D.size.x / 2)), 0, 0),
                    Vector2.down);
                Gizmos.DrawRay(transform.position + new Vector3((_currentDirection.x * (_collider2D.size.x / 2)), 0, 0),
                    _currentDirection*_visionDistance);
            }
        }
    }
}