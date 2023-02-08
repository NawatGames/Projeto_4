using Enemies.Shooter;
using EventSystem;
using Main_Scripts.ElementSystem;
using Main_Scripts.EventSystem.SimpleEvents;
using UnityEngine;

namespace Main_Scripts.Enemies.Shooter {
    public class ShotPrefabs : MonoBehaviour {
        [SerializeField] private GameObject _prefabToShoot;
        [SerializeField] private ElementSO bulletElementToShot;
        [SerializeField] private NoTypeGameEvent bulletDestroyedEvent;

        private GameObject _instantiatedBullet;
        public void ShotPrefab(Vector2 direction) {
            var angle = NormalizeAngle(direction);
            if (direction.y >= 0) _instantiatedBullet = Instantiate(_prefabToShoot, transform.position, Quaternion.AngleAxis(angle, Vector3.forward));
            else _instantiatedBullet = Instantiate(_prefabToShoot, transform.position, Quaternion.AngleAxis(angle + 180, Vector3.forward));
            _instantiatedBullet.AddComponent<BulletMoverMonoBehaviour>().Initialize(direction, 6f);
            _instantiatedBullet.GetComponent<Rigidbody2D>().gravityScale = 0;
            _instantiatedBullet.AddComponent<BulletElementHandler>().InitializeBullet(bulletElementToShot, bulletDestroyedEvent);
        }

        private float NormalizeAngle(Vector2 vector) {
            if (vector.y > 0) 
                return Vector2.Angle(vector, Vector2.right);            
            return 180 - Vector2.Angle(vector, Vector2.right);
        }
    }
}