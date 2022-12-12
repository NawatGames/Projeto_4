using UnityEngine;

namespace Enemies.Shooter {
    public class ShotPrefabs : MonoBehaviour {
        [SerializeField] private GameObject _prefabToShoot;

        public void ShotPrefab(Vector2 direction) {
            var gameObject = Instantiate(_prefabToShoot, transform.position, Quaternion.identity);
            gameObject.AddComponent<BulletMonoBehaviour>().Initialize(direction, 3f);
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
    }
}