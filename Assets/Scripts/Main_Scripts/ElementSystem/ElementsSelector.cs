using EventSystem.SimpleEvents;
using UnityEngine;

namespace ElementSystem {
    [RequireComponent(typeof(ElementGeneratorMonoBehaviour))]
    public class ElementsSelector : MonoBehaviour {
        [SerializeField] private IntegerEvent eventToListen;
        private ElementGeneratorMonoBehaviour _generatorMonoBehaviour;
        private PrimeElementSO[] _currentPrimesSelectedArray = new PrimeElementSO[2];
        private ElementSO _currentElementSelected;

        private void Awake() {
            _generatorMonoBehaviour = GetComponent<ElementGeneratorMonoBehaviour>();
        }
        
        private void OnEnable() {
            eventToListen.SubscribeUnityEvent(SelectElementFromIndex);
        }

        private void OnDisable() {
            eventToListen.UnsubscribeUnityEvent(SelectElementFromIndex);
        }
        
        public void SelectElementFromIndex(int inputIndex) {
            var index = inputIndex - 1;
            if(index >= _generatorMonoBehaviour.AllPrimeElementsArray.Length)
                return;

            if (_currentPrimesSelectedArray[0] == null) {
                var primeElementSelected = _generatorMonoBehaviour.AllPrimeElementsArray[index];
                _currentElementSelected = primeElementSelected;
                _currentPrimesSelectedArray[0] = primeElementSelected;
                return;
            }

            if (_currentPrimesSelectedArray[0] != null && _currentPrimesSelectedArray[1] == null) {
                _currentPrimesSelectedArray[1] = _generatorMonoBehaviour.AllPrimeElementsArray[index];
                _currentElementSelected = _generatorMonoBehaviour.CreateAElement(ref _currentPrimesSelectedArray);
                
                _currentPrimesSelectedArray[0] = null;
                _currentPrimesSelectedArray[1] = null;
                
                return;
            }
        }


    }
}