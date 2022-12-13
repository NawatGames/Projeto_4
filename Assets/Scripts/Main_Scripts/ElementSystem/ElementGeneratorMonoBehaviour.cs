using UnityEngine;

namespace ElementSystem {
    [RequireComponent(typeof(AllPrimeElementsContainer), typeof(AllSecondaryElementsContainer))]
    public class ElementGeneratorMonoBehaviour : MonoBehaviour {
        private ElementGenerator _generator;
        private AllPrimeElementsContainer _allPrimeElementsContainer;
        private AllSecondaryElementsContainer _secondaryElementsContainer;

        private void Awake() {
            _allPrimeElementsContainer = GetComponent<AllPrimeElementsContainer>();
            _secondaryElementsContainer = GetComponent<AllSecondaryElementsContainer>();
            _generator = new ElementGenerator(ref _secondaryElementsContainer.AllSecondaryElements);
        }
        public SecondaryElementSO CreateAElement(ref PrimeElementSO[] primeElementsArray) {
            return _generator.GetValueFromKey(primeElementsArray);
        }

        public PrimeElementSO[] AllPrimeElementsArray => _allPrimeElementsContainer.PrimeElementsArray;
        public SecondaryElementSO[] AllSecondaryElementsArray => _secondaryElementsContainer.AllSecondaryElements;

    }
}