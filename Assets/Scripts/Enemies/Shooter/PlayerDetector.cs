using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Enemies.Shooter {
    
    [RequireComponent(typeof(CircleCollider2D))]
    public class PlayerDetector : MonoBehaviour {
        [SerializeField] private UnityEvent _playerDetectedEvent;
        [SerializeField] private float _delayInSeconds;
        private CircleCollider2D _collider;
        private GameObject _playerInstance;

        private void Awake() {
            _collider = GetComponent<CircleCollider2D>();
            _playerInstance = GameObject.FindGameObjectWithTag("Player");
        }

        private void OnTriggerEnter2D(Collider2D col) {
            if (col.gameObject == _playerInstance) {
                StartCheckPlayerVisibilityCoroutine(_delayInSeconds);
            }
        }
        
        private void OnTriggerExit2D(Collider2D col) {
            if (col.gameObject == _playerInstance) {
                StopAllCoroutines();
            }
        }


        public void StartCheckPlayerVisibilityCoroutine(float delayInSeconds) {
            StartCoroutine(CheckIfPlayerIsVisibleCoroutine(delayInSeconds));
        }
        
        private IEnumerator CheckIfPlayerIsVisibleCoroutine(float delayInSeconds) {
            var enemyPosition = transform.position;
            var playerPosition = _playerInstance.transform.position;
            var direction = (playerPosition - enemyPosition).normalized;

            while (true) {
                if (Physics2D.Raycast(enemyPosition, direction, _collider.radius)) {
                    _playerDetectedEvent.Invoke();
                }

                yield return new WaitForSeconds(delayInSeconds);
            }
        }

      

    }
}