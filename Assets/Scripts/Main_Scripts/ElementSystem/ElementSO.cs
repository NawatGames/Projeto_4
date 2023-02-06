using Main_Scripts.Platform.PlatformBehaviours;
using UnityEngine;

namespace Main_Scripts.ElementSystem {
    public class ElementSO : ScriptableObject {
        public BaseBehaviourSO[] PlatformBehavioursArray;
        public Sprite[] platformIdleSprites;

        public Sprite[] platformSpawnSprites;
        
        public Sprite bulletSprite;
        public ElementSO elementToLoseFor;
    }
}