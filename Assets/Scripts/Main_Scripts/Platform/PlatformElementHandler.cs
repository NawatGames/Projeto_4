using Main_Scripts.ElementSystem;
using UnityEngine;

namespace Main_Scripts.Platform {
    public class PlatformElementHandler : MonoBehaviour {
        private ElementSO _platformElement;

        public void Inialize(ElementSO element) {
            _platformElement = element;
            GetComponent<SpriteRenderer>().sprite = _platformElement.platformSprite;
            
            foreach (var itemElement in _platformElement.PlatformBehavioursArray) {
                itemElement?.StartBehaviour(gameObject);
            }
            
        }

        private void Update() {   
            foreach (var itemElement in _platformElement.PlatformBehavioursArray) {
                itemElement?.UpdateBehaviour(gameObject);
            }
        }


        private void OnCollisionEnter2D(Collision2D col) {
            foreach (var itemElement in _platformElement.PlatformBehavioursArray) {
                itemElement?.OnCollisionEventResponse(gameObject, col);
            }
        }

        private void OnTriggerEnter2D(Collider2D col) {
            foreach (var itemElement in _platformElement.PlatformBehavioursArray) {
                itemElement?.OnTriggerEventResponse(gameObject, col);
            }
        }

        public ElementSO PlatformElement => _platformElement;
    }
}