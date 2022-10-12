using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace EventSystem {
    [CreateAssetMenu(fileName = "Game_Event", menuName = "Scriptable Objects/Event")]
    public class GameEventSO : ScriptableObject, IGameEvent {
        private HashSet<UnityEvent> _unityEventsSet;
        
        private void OnEnable() {
            _unityEventsSet = new HashSet<UnityEvent>();
        }

        public void InvokeEvent() {
            foreach (var unityEvent in _unityEventsSet) {
                unityEvent?.Invoke();
            }
        }
        
        public void SubscribeUnityEvent(UnityEvent unityEvent) {
            _unityEventsSet.Add(unityEvent);
        }

        public void UnsubscribeUnityEvent(UnityEvent unityEvent) {
            _unityEventsSet.Remove(unityEvent);
        }
    }
}