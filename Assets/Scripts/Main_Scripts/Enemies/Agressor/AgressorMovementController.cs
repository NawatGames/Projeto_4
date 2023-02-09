using Movement_System;
using UnityEngine;

namespace Enemies.Agressor {
    [RequireComponent(typeof(CharacterMovementHandler))]
    public class AgressorMovementController : MonoBehaviour {
        public bool canWalk = true;
        [SerializeField] private float _speedPatrolMode;
        [SerializeField] private float _speedChaseMode;
        [SerializeField] private float _visionDistance;

        [SerializeField] private BoxCollider2D _agressorCollider2D;
        [SerializeField] private Animator _agressorAnimator;
        private CharacterMovementHandler _movementHandler;
        private Vector2 _currentDirection = Vector2.right;
        private float _currentSpeed;

        private string _playerTag = "Player";
        private Vector3 _eyePosition;
        private Vector3 _floorScanPosition;

        private float _colliderSizeInX;
        private float _colliderSizeInY;

        private void Awake() {
            _movementHandler = GetComponent<CharacterMovementHandler>();
            _currentSpeed = _speedPatrolMode;

            // Calculating positions to use in raycasting
            _colliderSizeInX = _agressorCollider2D.size.x * _agressorCollider2D.gameObject.transform.localScale.x / 2;
            _colliderSizeInY = _agressorCollider2D.size.y * _agressorCollider2D.gameObject.transform.localScale.y / 2;
            UpdatePositions();
        }

        private void Update() {
            _movementHandler.Move(_currentDirection, _currentSpeed);
            UpdatePositions();
            Debug.Log("EyePoint: (" + _eyePosition.x + ", " + _eyePosition.y + ")");
            Debug.Log("FloPoint: (" + _floorScanPosition.x + ", " + _floorScanPosition.y + ")");

            if (!CheckDown() || CheckIfTheresSomethingBesidesThePlayerAhead()) {
                _currentDirection *= -1;
                var wolfTransform = _agressorCollider2D.gameObject.transform;
                wolfTransform.RotateAround(wolfTransform.position, wolfTransform.up, 180f);
            }

            if (CheckIfPlayerIsAhead()) {
                _currentSpeed = _speedChaseMode;
                _agressorAnimator.SetTrigger("Running");
            }
            else {
                _currentSpeed = _speedPatrolMode;
                _agressorAnimator.SetTrigger("Walking");
            }
        }

        private bool CheckIfPlayerIsAhead() {
            var hit = CheckAhead();
            if(hit) return hit.transform.CompareTag(_playerTag);
            return false;
        }
        
        private bool CheckIfTheresSomethingBesidesThePlayerAhead() {
            var hit = CheckAhead();
            if (hit.transform != null){
                var isPlayerHit = hit.transform.CompareTag(_playerTag);
                var hitPosition = hit.transform.position;
                var hitDistance = Vector2.Distance(_eyePosition, hitPosition);
                var isCloseToWall = hitDistance <= _agressorCollider2D.size.x + 0.5f;
                if(hit) return !isPlayerHit && isCloseToWall;
                return false;
            }
            else return false;
        }

        private bool CheckDown() {
            var rayCast = Physics2D.Raycast(_floorScanPosition, Vector2.down, 1f);
            var verify = rayCast.transform != null;
            if (verify) Debug.Log("Down view: " + rayCast.transform.gameObject.name);
            else Debug.Log("Down view: null");
            return verify;
        }
        
        private RaycastHit2D CheckAhead() {
            var rayCast = Physics2D.Raycast(_eyePosition, _currentDirection, _visionDistance);
            var verify = rayCast.transform != null;
            if (verify) Debug.Log("Foward view: " + rayCast.transform.gameObject.name);
            else Debug.Log("Foward view: null");
            return rayCast;
        }

        private void OnDrawGizmos() {
            if(Application.isPlaying) {
                Gizmos.DrawRay(_floorScanPosition, Vector2.down);
                Gizmos.DrawRay(_eyePosition, _currentDirection * _visionDistance);
            }
        }

        private void UpdatePositions(){
            var dir = _currentDirection.x;
            var yOffset = _agressorCollider2D.offset.y * _agressorCollider2D.gameObject.transform.localScale.y;
            _eyePosition = transform.position + dir * new Vector3( _colliderSizeInX + 0.01f, 0f, 0f);
            _floorScanPosition = transform.position + new Vector3( dir * (_colliderSizeInX + 0.01f), -_colliderSizeInY + yOffset, 0f);
        }
    }
}