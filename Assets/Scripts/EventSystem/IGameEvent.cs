using UnityEngine.Events;

namespace EventSystem {
    public interface IGameEvent {
        void InvokeEvent();
        void SubscribeUnityEvent(UnityEvent unityEvent);
        void UnsubscribeUnityEvent(UnityEvent unityEvent);
    }
}