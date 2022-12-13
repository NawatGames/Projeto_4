using UnityEngine;

namespace ElementSystem {
    [CreateAssetMenu(fileName = "new Secondary Element", menuName = "Secondary Element")]
    public class SecondaryElementSO : ScriptableObject {
        //Aqui teremos os sprites de plataforma e os comportamentos que elas terao de acordo com o elemento
        
        public PrimeElementSO[] _primeElementsComposerArray;
    }
}