using System;
using EventSystem.SimpleEvents;
using UnityEngine;

namespace DefaultNamespace {
    public class Teste : MonoBehaviour {
        public IntegerEvent Event;

        private void OnEnable() {
            Event.SubscribeUnityEvent(kappa => print(kappa));
        }
    }
}