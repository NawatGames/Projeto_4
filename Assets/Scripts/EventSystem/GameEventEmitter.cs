
using UnityEngine;

namespace EventSystem {
    public abstract class GameEventEmitter : MonoBehaviour{
        public GameEventSO eventToEmmit;

        public void InvokeGameEvent() {
            eventToEmmit.InvokeEvent();
        }
    }
}