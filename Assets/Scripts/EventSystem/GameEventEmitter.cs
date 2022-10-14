
using UnityEngine;

namespace EventSystem {
    public abstract class GameEventEmitter{
        public GameEventSO eventToEmmit;

        public void InvokeGameEvent(GameEventSO eventToInvoke) {
            eventToInvoke?.InvokeEvent();
        }
    }
}