using System.Collections;
using EventSystem;
using Main_Scripts.EventSystem.SimpleEvents;
using UnityEngine;

namespace Main_Scripts.Platform {
    public class DecaySystem : MonoBehaviour {
        [SerializeField] private float decayDurationInSeconds;
        [SerializeField] private NoTypeGameEvent eventToTriggerOnDecay;


        public void StartDecayCoroutine() {
            StartCoroutine(DecayCoroutine(decayDurationInSeconds));
        }
        
        private IEnumerator DecayCoroutine(float durationInSeconds) {
            yield return new WaitForSeconds(durationInSeconds);
            
            eventToTriggerOnDecay.InvokeEvent();
        }

        public void Testando() {
            Destroy(gameObject);
        }
    }
}