using EventSystem;
using EventSystem.SimpleEvents;
using Main_Scripts.EventSystem.SimpleEvents;
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
            var platformPosition = initialEndPointPair.Item2 - Vector2.right * initialEndPointPair.Item2.x * 0.5f;
         
            var vectorAngle = NormalizeAngle(originalVector);

            var platformGameobj = Instantiate(platformPrefab, platformPosition,
                Quaternion.AngleAxis(ClampAngle(vectorAngle), Vector3.forward));
            
            platformGameobj.GetComponent<PlatformElementHandler>().Inialize(elementSelectedSingleton.Value);
            platformGameobj.GetComponent<DecaySystem>().StartDecayCoroutine();
            
            var animator = platformGameobj.AddComponent(typeof(Animator)) as Animator;
            animator.runtimeAnimatorController = elementSelectedSingleton.Value.animatorController;

            if (ClampAngle(vectorAngle) == 90f)
                platformGameobj.GetComponent<PlatformEffector2D>().enabled = false;
            
            if(_cleanElementSelectionOnSpawn) {
                elementSelectedSingleton.Value = null;
                SpawnEvent.InvokeEvent();
            }
        }

        private float NormalizeAngle(Vector2 vector) {
            if (vector.y > 0) 
                return Vector2.Angle(vector, Vector2.right); //Se estiver no primeiro ou segundo quadrante
            
            return 180 - Vector2.Angle(vector, Vector2.right);
        }

        private float ClampAngle(float angle){
            if (angle < 22.5) return 0f;
            if (angle >= 22.5 && angle <= 67.5) return 45f;
            if (angle > 67.5 && angle <= 90) return 90f;
            if (angle < 112.5 && angle >= 90) return 90f;
            if (angle >= 112.5 && angle <= 157.5) return 315f;
             
            return 0;
        }
        
    }
}