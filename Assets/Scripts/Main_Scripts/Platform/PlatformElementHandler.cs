using Main_Scripts.ElementSystem;
using Main_Scripts.SingletonsSO;
using UnityEngine;

namespace Main_Scripts.Platform {
    public class PlatformElementHandler : MonoBehaviour {
        private ElementSO _platformElement;
        [SerializeField] private ElementSelectedSingleton elementSelectedSingleton;
        [SerializeField] private ElementSO fire_element;
        [SerializeField] private ElementSO glass_element;
        [SerializeField] private ElementSO ground_element;
        [SerializeField] private ElementSO water_element;
        [SerializeField] private ElementSO wind_element;

        [SerializeField] private Color fire_color;
        [SerializeField] private Color glass_color;
        [SerializeField] private Color ground_color;
        [SerializeField] private Color water_color;
        [SerializeField] private Color wind_color;

        private SpriteRenderer sr;

        public void Inialize(ElementSO element) {
            _platformElement = element;
            sr = GetComponent<SpriteRenderer>();
            sr.sprite = _platformElement.platformInitialSprite;
            foreach (var itemElement in _platformElement.PlatformBehavioursArray) {
                itemElement?.StartBehaviour(gameObject);
            }
            if (_platformElement == fire_element) sr.sortingOrder = sr.sortingOrder + 2;
            if (_platformElement == glass_element) sr.sortingOrder = sr.sortingOrder + 4;
            if (_platformElement == ground_element) sr.sortingOrder = sr.sortingOrder + 5;
            if (_platformElement == water_element) sr.sortingOrder = sr.sortingOrder + 3;
            if (_platformElement == wind_element) sr.sortingOrder = sr.sortingOrder + 1;
        }

        private void Update() {   
            if(_platformElement == glass_element){
                var currSelectedElement = elementSelectedSingleton.Value;
                if (currSelectedElement == fire_element) sr.color = fire_color;
                else if (currSelectedElement == glass_element) sr.color = glass_color;
                else if (currSelectedElement == ground_element) sr.color = ground_color;
                else if (currSelectedElement == water_element) sr.color = water_color;
                else if (currSelectedElement == wind_element) sr.color = wind_color;
                else sr.color = Color.white;
            }
            
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