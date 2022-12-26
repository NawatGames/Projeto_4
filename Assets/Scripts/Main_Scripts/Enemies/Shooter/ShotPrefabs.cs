using Enemies.Shooter;
using EventSystem;
using Main_Scripts.ElementSystem;
using UnityEngine;

namespace Main_Scripts.Enemies.Shooter {
    public class ShotPrefabs : MonoBehaviour {
        [SerializeField] private GameObject _prefabToShoot;
        [SerializeField] private ElementSO bulletElementToShot;
        [SerializeField] private NoTypeGameEvent bulletDestroyedEvent;
        public void ShotPrefab(Vector2 direction) {
            var gameObject = Instantiate(_prefabToShoot, transform.position, Quaternion.identity);
            gameObject.AddComponent<BulletMoverMonoBehaviour>().Initialize(direction, 3f);
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            gameObject.AddComponent<BulletElementHandler>().InitializeBullet(bulletElementToShot, bulletDestroyedEvent);
        }
    }
}