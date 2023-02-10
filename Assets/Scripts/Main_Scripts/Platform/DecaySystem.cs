using System.Collections;
using Main_Scripts.EventSystem.SimpleEvents;
using UnityEngine;

namespace Main_Scripts.Platform {
    public class DecaySystem : MonoBehaviour {
        [SerializeField] private float decayDurationInSeconds;
        [SerializeField] private NoTypeGameEvent eventToTriggerOnDecay;
        [SerializeField] private bool destroyAfterDecay = true;

        private bool isShaking = false;

        private void Update() {
            if (isShaking){
                var originalPosition = transform.position;
                gameObject.transform.position = new Vector3(originalPosition[0] + Mathf.Sin(Time.time * 1000) * 0.1f, originalPosition[1], originalPosition[2]);
            }
        }

        public void StartDecayCoroutine() {
            StartCoroutine(DecayCoroutine(decayDurationInSeconds));
        }
        
        private IEnumerator DecayCoroutine(float durationInSeconds) {
            yield return new WaitForSeconds(durationInSeconds/4);
            yield return new WaitForSeconds(durationInSeconds/4);
            Shake();
            yield return new WaitForSeconds(durationInSeconds/4);
            StopShaking();
            Fall();
            yield return new WaitForSeconds(durationInSeconds/4);

            eventToTriggerOnDecay.InvokeEvent();
            if (destroyAfterDecay) {
                yield return new WaitForSeconds(Time.deltaTime);
                DestroyPlatform();
            }
        }

        public void DestroyPlatform() {
            Destroy(gameObject);
        }

        private void Shake(){
            isShaking = true;
        }

        private void StopShaking(){
            isShaking = false;
        }

        private void Fall(){
            var rb = gameObject.GetComponent<Rigidbody2D>();
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.gravityScale = 10;
        }
    }
}