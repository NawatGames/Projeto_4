using Enemies.Shooter;
using EventSystem;
using Main_Scripts.ElementSystem;
using Main_Scripts.EventSystem.SimpleEvents;
using UnityEngine;
using Main_Scripts.SingletonsSO;

namespace Main_Scripts.Enemies.Shooter {
    public class ShotPrefabs : MonoBehaviour {
        [SerializeField] private GameObject _prefabToShoot;
        [SerializeField] private ElementSO bulletElementToShot;
        [SerializeField] private NoTypeGameEvent bulletDestroyedEvent;
        [SerializeField] private ElementSelectedSingleton elementSelectedSingleton;
        [SerializeField] private ElementSO fire_element;
        [SerializeField] private ElementSO glass_element;
        [SerializeField] private ElementSO ground_element;
        [SerializeField] private ElementSO water_element;
        [SerializeField] private ElementSO wind_element;

        private GameObject _instantiatedBullet;
        private Vector3 shotPositionOffset = new Vector3(0.132f, -0.086f, 0); // got from children gameobject
        public void ShotPrefab(Vector2 direction) {
            var angle = NormalizeAngle(direction);
            var shotPosition = transform.position + shotPositionOffset * Mathf.Max(transform.localScale.x, transform.localScale.y);
            if (direction.y >= 0) _instantiatedBullet = Instantiate(_prefabToShoot, shotPosition, Quaternion.AngleAxis(angle, Vector3.forward));
            else _instantiatedBullet = Instantiate(_prefabToShoot, shotPosition, Quaternion.AngleAxis(angle + 180, Vector3.forward));
            _instantiatedBullet.AddComponent<BulletMoverMonoBehaviour>().Initialize(direction, 6f);
            _instantiatedBullet.GetComponent<Rigidbody2D>().gravityScale = 0;
            var elHandl = _instantiatedBullet.AddComponent<BulletElementHandler>();
            elHandl.InitializeBullet(bulletElementToShot, bulletDestroyedEvent);
            elHandl.FillBulllet(
                fire_element,
                glass_element,
                ground_element,
                water_element,
                wind_element,
                elementSelectedSingleton
            );
        }

        private float NormalizeAngle(Vector2 vector) {
            if (vector.y > 0) 
                return Vector2.Angle(vector, Vector2.right);            
            return 180 - Vector2.Angle(vector, Vector2.right);
        }
    }
}