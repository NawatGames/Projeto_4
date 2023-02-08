using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Enemies.Shooter {
    
    [RequireComponent(typeof(CircleCollider2D))]
    public class PlayerDetector : MonoBehaviour {
        [SerializeField] private UnityEvent<Vector2> _playerDetectedEvent;
        [SerializeField] private float delayInSeconds;
        [SerializeField] private LayerMask layerMasks;
        private CircleCollider2D _collider;
        private GameObject _playerInstance;
        private Coroutine _playerVisibilityCoroutine;
        

        private void Awake() {
            _collider = GetComponent<CircleCollider2D>();
            _playerInstance = GameObject.FindGameObjectWithTag("Player");
        }

        private void OnTriggerEnter2D(Collider2D col) {
            if (col.gameObject == _playerInstance) {
                _playerVisibilityCoroutine = StartCoroutine(CheckIfPlayerIsVisibleCoroutine(delayInSeconds));
            }
        }
        
        private void OnTriggerExit2D(Collider2D col) {
            StopShottingCorroutineIfIsPlayer(col.gameObject);
        }

        private void StopShottingCorroutineIfIsPlayer(GameObject objectToCompare){
            if (objectToCompare == _playerInstance) {
                if (_playerVisibilityCoroutine != null) StopCoroutine(_playerVisibilityCoroutine);
            }
        }
        
        private IEnumerator CheckIfPlayerIsVisibleCoroutine(float delayInSeconds) {
            while (true) {
                var enemyPosition = transform.position;
                var playerPosition = _playerInstance.transform.position;
                var direction = (playerPosition - enemyPosition).normalized;
                var distanceX = _collider.radius * gameObject.transform.localScale.x;
                var distanceY = _collider.radius * gameObject.transform.localScale.y;
                var raycastHit2D = Physics2D.Raycast(enemyPosition , direction, Mathf.Max(distanceX, distanceY), layerMasks);
                if (raycastHit2D && raycastHit2D.transform.gameObject == _playerInstance) {
                    _playerDetectedEvent?.Invoke(direction);
                }
                yield return new WaitForSeconds(delayInSeconds);
            }
        }

      

    }
}