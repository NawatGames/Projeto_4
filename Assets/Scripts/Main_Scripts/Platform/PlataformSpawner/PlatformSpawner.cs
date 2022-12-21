using EventSystem;
using EventSystem.SimpleEvents;
using Main_Scripts.Platform;
using Main_Scripts.SingletonsSO;
using UnityEngine;

namespace Main_Scripts.PlataformSpawner {
    public class PlatformSpawner : MonoBehaviour {
        public Vector2TupleEvent eventToListen;
        [SerializeField] private GameObject platformPrefab;
        [SerializeField] private ElementSelectedSingleton elementSelectedSingleton;
        [SerializeField] private NoTypeGameEvent SpawnEvent;
        
        [Header("Designers, decidam isso")]
        [SerializeField] private bool _cleanElementSelectionOnSpawn;
        private void OnEnable() {
            eventToListen.SubscribeUnityEvent(SpawnPlatform);
        }

        private void OnDisable() {
            eventToListen.UnsubscribeUnityEvent(SpawnPlatform);
        }

        public void SpawnPlatform((Vector2, Vector2) initialEndPointPair) {
            if (elementSelectedSingleton.Value == null)
                return;
           
            var originalVector = initialEndPointPair.Item2 - initialEndPointPair.Item1;
            var platformPosition = initialEndPointPair.Item2 - Vector2.right * 0.5f;
         
            var vectorAngle = NormalizeAngleToFirstQuarter(Vector2.Angle(originalVector, Vector2.right));

            print($"Ponto inicial: x: {initialEndPointPair.Item1.x} y: {initialEndPointPair.Item1.y}");
            print($"Ponto final: x: {initialEndPointPair.Item2.x} y: {initialEndPointPair.Item2.y}");
            var platformGameobj = Instantiate(platformPrefab, platformPosition,
                Quaternion.AngleAxis(CaparOAngulo(vectorAngle), Vector3.forward));
            
            platformGameobj.GetComponent<PlatformElementHandler>().Inialize(elementSelectedSingleton.Value);
            platformGameobj.GetComponent<DecaySystem>().StartDecayCoroutine();
            
            if(_cleanElementSelectionOnSpawn) {
                elementSelectedSingleton.Value = null;
                SpawnEvent.InvokeEvent();
            }
        }

        private float NormalizeAngleToFirstQuarter(float angle) {
            print(angle);
            if (angle <= 180) return angle;
            return 180 - angle;
        }

        private float CaparOAngulo(float angle){
            if (angle < 22.5) return 0f;
            if (angle >= 22.5 && angle <= 67.5) return 45f;
            if (angle > 67.5 && angle <= 90) return 90f;
            if (angle < 112.5 && angle >= 90) return 90f;
            if (angle >= 112.5 && angle <= 157.5) return 135f;
             
            return 180;
        }
        
    }
}