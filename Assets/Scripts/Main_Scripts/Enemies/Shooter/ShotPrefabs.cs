using ElementSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Enemies.Shooter {
    public class ShotPrefabs : MonoBehaviour {
        [SerializeField] private GameObject _prefabToShoot;
        [SerializeField] private ElementSO bulletElementToShot;
        [SerializeField] private UnityEvent bulletCollideOppositeElementEvent;
        [SerializeField] private UnityEvent bulletCollideSimpleEvent;
        public void ShotPrefab(Vector2 direction) {
            var gameObject = Instantiate(_prefabToShoot, transform.position, Quaternion.identity);
            gameObject.AddComponent<BulletMoverMonoBehaviour>().Initialize(direction, 3f);
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            gameObject.AddComponent<BulletElementHandler>().InitializeBullet(bulletElementToShot, ref bulletCollideOppositeElementEvent, ref bulletCollideSimpleEvent);
        }
    }
}