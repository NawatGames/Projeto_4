using UnityEngine;
using EventSystem.SimpleEvents;

namespace Main_Scripts.Platform
{
    public class PlatformAnimation : MonoBehaviour
    {
        public AnimatePlatformEvent eventToListen;
        private Animator _animator;
        private AnimatorControllerParameter _elementMap;

        private void Start() {
            _animator = gameObject.GetComponent<Animator>();
            _elementMap = _animator.parameters[0];
        }
        
        private void OnEnable() {
            eventToListen.SubscribeUnityEvent(AnimatePlatform);
        }

        private void OnDisable() {
            eventToListen.UnsubscribeUnityEvent(AnimatePlatform);
        }

        public void AnimatePlatform(int elementIndex){
            _animator.SetInteger(_elementMap.name, elementIndex);
        }
    }
}
