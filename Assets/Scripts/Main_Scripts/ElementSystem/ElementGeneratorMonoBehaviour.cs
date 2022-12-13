using UnityEngine;

namespace ElementSystem {
    [RequireComponent(typeof(AllPrimeElementsContainer), typeof(AllSecondaryElementsContainer))]
    public class ElementGeneratorMonoBehaviour : MonoBehaviour {
        private ElementGenerator _generator;
        private AllSecondaryElementsContainer _secondaryElementsContainer;

        [SerializeField] private PrimeElementSO[] primeElementArrayTesting;

        private void Awake() {
            _secondaryElementsContainer = GetComponent<AllSecondaryElementsContainer>();
            _generator = new ElementGenerator(ref _secondaryElementsContainer.AllSecondaryElements);
        }

        private void Start() {
            print(CreateAElement(ref primeElementArrayTesting).name);
        }

        public SecondaryElementSO CreateAElement(ref PrimeElementSO[] primeElementsArray) {
            return _generator.GetValueFromKey(primeElementsArray);
        }

    }
}