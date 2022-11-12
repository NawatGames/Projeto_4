using UnityEngine;
using UnityEngine.Events;

namespace EventSystem {
    public class GameEventListener : MonoBehaviour {
        [SerializeField] private GameEventSO eventToListen;
        [SerializeField] private UnityEvent eventListener;
        
        private void OnEnable() {
            eventToListen.SubscribeUnityEvent(eventListener);
        }

        private void OnDisable() {
            eventToListen.UnsubscribeUnityEvent(eventListener);
        }
    }
}