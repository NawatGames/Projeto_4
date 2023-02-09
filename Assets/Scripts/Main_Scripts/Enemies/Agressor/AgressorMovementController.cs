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

        private string _playerTag = "Player";
        private Vector3 _eyePosition;
        private Vector3 _floorScanPosition;

        private void Awake() {
            _movementHandler = GetComponent<CharacterMovementHandler>();
            _currentSpeed = _speedPatrolMode;

            // Calculating positions to use in raycasting
            var collliderSizeInX = _collider2D.size.x * gameObject.transform.localScale.x / 2;
            var collliderSizeInY = _collider2D.size.y * gameObject.transform.localScale.y / 2;
            _eyePosition = transform.position + new Vector3( ( _currentDirection.x + collliderSizeInX ), 0f, 0f);
            _floorScanPosition = transform.position + new Vector3(collliderSizeInX, -collliderSizeInY, 0f);
        }

        private void Update() {
            _movementHandler.Move(_currentDirection, _currentSpeed);

            if (!CheckDown() || CheckIfTheresAWallAhead()) {
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
                return hit.transform.CompareTag(_playerTag);
            return false;
        }
        
        private bool CheckIfTheresAWallAhead() {
            var hit = CheckAhead();
            var hitDistance = hit?Vector2.Distance(transform.position, hit.transform.position):Mathf.Infinity;
            if(hit)
                return !hit.transform.CompareTag(_playerTag) && hitDistance <= _collider2D.size.x+0.5f;
            return false;
        }

        private bool CheckDown() {
            var rayCast = Physics2D.Raycast(_floorScanPosition, Vector2.down, 1f);
            Debug.Log("Down view: " + rayCast.collider.gameObject.name);
            return rayCast;
        }
        
        private RaycastHit2D CheckAhead() {
            var rayCast = Physics2D.Raycast(_eyePosition, _currentDirection, _visionDistance);
            Debug.Log("Front view: " + rayCast.collider.gameObject.name);
            return rayCast;
        }

        private void OnDrawGizmos() {
            if(Application.isPlaying) {
                Gizmos.DrawRay(_floorScanPosition, Vector2.down);
                Gizmos.DrawRay(_eyePosition, _currentDirection * _visionDistance);
            }
        }
    }
}