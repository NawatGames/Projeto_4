using UnityEngine;
using UnityEngine.Events;

namespace EventSystem {
    public class GameEventListener : MonoBehaviour {
        [SerializeField] private GameEventSO _eventToListen;
        [SerializeField] private UnityEvent _eventListener;
        
        private void OnEnable() {
            _eventToListen.SubscribeUnityEvent(_eventListener);
        }

        private void OnDisable() {
            _eventToListen.UnsubscribeUnityEvent(_eventListener);
        }
    }
}