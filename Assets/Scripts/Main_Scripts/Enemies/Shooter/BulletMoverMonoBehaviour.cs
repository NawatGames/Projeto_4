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

        public void Reflect(GameObject platform){
            // Reflect
            _speedDiretion = Vector2.Reflect(_speedDiretion, platform.transform.up);
            // Rotate
            var angle = NormalizeAngle(_speedDiretion);
            // Apply
            if (_speedDiretion.y >= 0) _rgb.gameObject.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            else _rgb.gameObject.transform.rotation = Quaternion.AngleAxis(angle + 180, Vector3.forward);
            _rgb.velocity = _speedDiretion * _speed;
        }

        private float NormalizeAngle(Vector2 vector) {
            if (vector.y > 0) 
                return Vector2.Angle(vector, Vector2.right);            
            return 180 - Vector2.Angle(vector, Vector2.right);
        }
    }
}