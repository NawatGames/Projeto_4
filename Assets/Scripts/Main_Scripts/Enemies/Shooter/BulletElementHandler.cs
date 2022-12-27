using Main_Scripts.ElementSystem;
using Main_Scripts.EventSystem.SimpleEvents;
using Main_Scripts.Platform;
using UnityEngine;

namespace Main_Scripts.Enemies.Shooter {
    [RequireComponent(typeof(BoxCollider2D))]
    public class BulletElementHandler : MonoBehaviour {
        private ElementSO _bulletElement;
        private NoTypeGameEvent eventToTrigger;
        
        public void InitializeBullet(ElementSO elementSo, NoTypeGameEvent eventBulletDestroyed) {
            GetComponent<Collider2D>().isTrigger = true;
            _bulletElement = elementSo;
            GetComponent<SpriteRenderer>().sprite = _bulletElement.bulletSprite;
            eventToTrigger = eventBulletDestroyed;
        }

        public void ChangeElement(ElementSO elementSo) {
            _bulletElement = elementSo;
            GetComponent<SpriteRenderer>().sprite = _bulletElement.bulletSprite;
        }
        private void OnTriggerEnter2D(Collider2D col) {
            if (col.CompareTag("Platform")) {
                var platformElement = col.gameObject.GetComponent<PlatformElementHandler>().PlatformElement;
                if (platformElement == _bulletElement.elementToLoseFor) {
                    Destroy(gameObject);
                    eventToTrigger.InvokeEvent();
                }
            }
        }

    }
}