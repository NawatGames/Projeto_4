using ElementSystem;
using UnityEngine;

namespace Main_Scripts.Platform {
    public class PlatformElementHandler : MonoBehaviour {
        private ElementSO _platformElement;

        public void Inialize(ElementSO element) {
            _platformElement = element;
            print($"Inicializada com o elemento: {_platformElement.name}");
            
            //todo: alterar sprite da plataforma e outras coisas relacionadas aos elementos
        }
    }
}