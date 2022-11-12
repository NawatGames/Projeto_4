using UnityEngine;
using UnityEngine.Events;

namespace EventSystem
{
    public abstract class SimpleEventSO<T> : ScriptableObject
    {
        [SerializeField] private UnityEvent<T> simpleEvent = new UnityEvent<T>();
        public void InvokeEvent(T parameter)
        {
            simpleEvent.Invoke(parameter);
        }

        public void SubscribeUnityEvent(UnityAction<T> unityEvent)
        {
           simpleEvent.AddListener(unityEvent);
        }

        public void UnsubscribeUnityEvent(UnityAction<T> unityEvent)
        {
            simpleEvent.RemoveListener(unityEvent);
        }
    }
}