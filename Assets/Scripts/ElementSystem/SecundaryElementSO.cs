using UnityEngine;

namespace ElementSystem {
    [CreateAssetMenu(fileName = "Secundary Element", menuName = "new Secondary Element")]
    public class SecundaryElementSO : ScriptableObject {
        //Aqui teremos os sprites de plataforma e os comportamentos que elas terao de acordo com o elemento
        
        public PrimeElementSO[] _primeElementsComposerArray;
    }
}