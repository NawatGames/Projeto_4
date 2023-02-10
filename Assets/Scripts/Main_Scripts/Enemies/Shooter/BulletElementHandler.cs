using Main_Scripts.ElementSystem;
using Main_Scripts.EventSystem.SimpleEvents;
using Main_Scripts.Platform;
using System.Collections;
using Main_Scripts.SingletonsSO;
using Enemies.Shooter;
using UnityEngine;

namespace Main_Scripts.Enemies.Shooter {
    [RequireComponent(typeof(BoxCollider2D))]
    public class BulletElementHandler : MonoBehaviour {
        private ElementSO _bulletElement;
        private NoTypeGameEvent eventToTrigger;

        // Yes, fix later
        private BulletMoverMonoBehaviour _selfMover;
        public ElementSO fire_element;
        public ElementSO glass_element;
        public ElementSO ground_element;
        public ElementSO water_element;
        public ElementSO wind_element;
        public ElementSelectedSingleton elementSelectedSingleton;

        public void InitializeBullet(ElementSO elementSo, NoTypeGameEvent eventBulletDestroyed) {
            GetComponent<Collider2D>().isTrigger = true;
            _bulletElement = elementSo;
            GetComponent<SpriteRenderer>().sprite = _bulletElement.bulletSprite;
            eventToTrigger = eventBulletDestroyed;
            _selfMover = GetComponent<BulletMoverMonoBehaviour>();
            StartCoroutine(StartProjectileDestroyTimer(5f));
        }

        public void FillBulllet(
            ElementSO f_fire_element,
            ElementSO f_glass_element,
            ElementSO f_ground_element,
            ElementSO f_water_element,
            ElementSO f_wind_element,
            ElementSelectedSingleton f_elementSelectedSingleton
        ){
            fire_element = f_fire_element;
            glass_element = f_glass_element;
            ground_element = f_ground_element;
            water_element = f_water_element;
            wind_element = f_wind_element;
            elementSelectedSingleton = f_elementSelectedSingleton;
        }

        public void ChangeElement(ElementSO elementSo) {
            _bulletElement = elementSo;
            GetComponent<SpriteRenderer>().sprite = _bulletElement.bulletSprite;
        }

        private void OnTriggerEnter2D(Collider2D col) {
            if (col.CompareTag("Platform")) {
                var platHandler = col.gameObject.GetComponent<PlatformElementHandler>();
                if (platHandler == null) return;
                var platformElement = platHandler.PlatformElement;
                if (platformElement == null) return;
                var elementToLose = _bulletElement?.elementToLoseFor;
                if (elementToLose != null)
                    if (platformElement == _bulletElement.elementToLoseFor) {
                        Destroy(gameObject);
                        eventToTrigger?.InvokeEvent();
                    }
                if (platformElement == glass_element){
                    var newElement = elementSelectedSingleton.Value;
                    _selfMover.Reflect(col.gameObject);
                    if (newElement == glass_element) return;
                    ChangeElement(elementSelectedSingleton.Value);
                }
            }
        }
        
        private IEnumerator StartProjectileDestroyTimer(float delay){
            yield return new WaitForSeconds(delay);
            Destroy(gameObject);
            eventToTrigger?.InvokeEvent();
        }
    }
}