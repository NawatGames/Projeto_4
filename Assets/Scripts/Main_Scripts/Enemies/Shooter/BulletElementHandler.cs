using EventSystem;
using Main_Scripts.ElementSystem;
using Main_Scripts.Platform;
using UnityEngine;

namespace Main_Scripts.Enemies.Shooter {
    public class BulletElementHandler : MonoBehaviour {
        private ElementSO _bulletElement;
        private NoTypeGameEvent eventToTrigger;
        
        public void InitializeBullet(ElementSO elementSo, NoTypeGameEvent eventBulletDestroyed) {
            _bulletElement = elementSo;
            GetComponent<SpriteRenderer>().sprite = _bulletElement.bulletSprite;
            eventToTrigger = eventBulletDestroyed;
        }

        private void OnTriggerEnter2D(Collider2D col) {
            if (col.CompareTag("Platform")) {
                var platformElement = col.gameObject.GetComponent<PlatformElementHandler>().PlatformElement;
                if (platformElement == _bulletElement.opositeElement) {
                    Destroy(gameObject);
                    eventToTrigger.InvokeEvent();
                }
            }
        }

    }
}