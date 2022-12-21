using UnityEngine;
using UnityEngine.Events;

namespace EventSystem {
    public class NoTypeEventListener : MonoBehaviour {
        [SerializeField] private NoTypeGameEvent eventToListen;
        [SerializeField] private UnityEvent eventListener;
        
        private void OnEnable() {
            eventToListen.SubscribeUnityEvent(eventListener);
        }

        private void OnDisable() {
            eventToListen.UnsubscribeUnityEvent(eventListener);
        }
    }
}