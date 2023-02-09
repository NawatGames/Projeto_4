using UnityEngine;

namespace ElementSystem {
    public class AllPrimeElementsContainer : MonoBehaviour {
        public PrimeElementSO[] PrimeElementsArray;

        private void Start() {
            int index = 0;
            foreach (var element in PrimeElementsArray)
            {
                element.elementSpawnIndex = index;
                index++;
            }
        }
    }
}