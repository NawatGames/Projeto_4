using UnityEngine;

namespace Enemies.Shooter {
    [RequireComponent(typeof(Rigidbody2D))]
    public class BulletMoverMonoBehaviour : MonoBehaviour {
        [SerializeField] private float _speed;
        private Vector2 _speedDiretion;
        private Rigidbody2D _rgb;

        private void Awake() {
            _rgb = GetComponent<Rigidbody2D>();
        }

        public void Initialize(Vector2 speedDirection, float speed) {
            _speed = speed;
            _speedDiretion = speedDirection;
            _rgb.velocity = _speedDiretion * _speed;
        }
    }
}