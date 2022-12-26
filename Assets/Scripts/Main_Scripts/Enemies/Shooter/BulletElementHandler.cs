using ElementSystem;
using Main_Scripts.Platform;
using UnityEngine;
using UnityEngine.Events;

namespace Enemies.Shooter {
    public class BulletElementHandler : MonoBehaviour {
        private UnityEvent _collideWithOppositePlatformEvent;
        private UnityEvent _collideWithSimplePlatformEvent;
        private ElementSO _bulletElement;
        
        public void InitializeBullet(ElementSO elementSo, ref UnityEvent collideOpposite, ref UnityEvent collideSimple) {
            _bulletElement = elementSo;
            GetComponent<SpriteRenderer>().sprite = _bulletElement.bulletSprite;
            _collideWithOppositePlatformEvent = collideOpposite;
            _collideWithSimplePlatformEvent = collideSimple;
        }

        private void OnTriggerEnter2D(Collider2D col) {
            if (col.CompareTag("Platform")) {
                var platformElement = col.gameObject.GetComponent<PlatformElementHandler>().PlatformElement;
                if (platformElement == _bulletElement.opositeElement) {
                    _collideWithOppositePlatformEvent.Invoke();
                    return;
                }
                _collideWithSimplePlatformEvent.Invoke();
            }
        }

    }
}