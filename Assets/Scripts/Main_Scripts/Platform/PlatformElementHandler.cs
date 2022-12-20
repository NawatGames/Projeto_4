using System;
using ElementSystem;
using UnityEngine;

namespace Main_Scripts.Platform {
    public class PlatformElementHandler : MonoBehaviour {
        private ElementSO _platformElement;

        public void Inialize(ElementSO element) {
            _platformElement = element;
            print($"Inicializada com o elemento: {_platformElement.name}");
            
            _platformElement.PlatformBehaviour.StartBehaviour(gameObject);
        }

        private void Update() {
            _platformElement.PlatformBehaviour.UpdateBehaviour(gameObject);
        }


        private void OnCollisionEnter2D(Collision2D col) {
            _platformElement.PlatformBehaviour.OnCollisionEventResponse(col);
        }
    }
}