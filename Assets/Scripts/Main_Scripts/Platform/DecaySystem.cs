using System.Collections;
using Main_Scripts.EventSystem.SimpleEvents;
using UnityEngine;

namespace Main_Scripts.Platform {
    public class DecaySystem : MonoBehaviour {
        [SerializeField] private float decayDurationInSeconds;
        [SerializeField] private NoTypeGameEvent eventToTriggerOnDecay;
        [SerializeField] private bool destroyAfterDecay = true;


        public void StartDecayCoroutine() {
            StartCoroutine(DecayCoroutine(decayDurationInSeconds));
        }
        
        private IEnumerator DecayCoroutine(float durationInSeconds) {
            yield return new WaitForSeconds(durationInSeconds);

            eventToTriggerOnDecay.InvokeEvent();
            if (destroyAfterDecay) {
                yield return new WaitForSeconds(Time.deltaTime);
                DestroyPlatform();
            }
        }

        public void DestroyPlatform() {
            Destroy(gameObject);
        }
    }
}