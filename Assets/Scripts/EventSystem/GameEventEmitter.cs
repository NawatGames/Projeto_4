
using UnityEngine;

namespace EventSystem {
    public abstract class GameEventEmitter : MonoBehaviour{

        protected void InvokeGameEvent(GameEventSO eventToInvoke) {
            eventToInvoke?.InvokeEvent();
        }
    }
}