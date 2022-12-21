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
        [SerializeField] private GameEventSO SpawnEvent;

        [Header("Designers, decidam isso")]
        [SerializeField] private bool _cleanSelectionOnSpawn;
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
            var platformPosition = initialEndPointPair.Item2 - Vector2.right * (originalVector.x/2);
            
            Instantiate(platformPrefab, platformPosition, Quaternion.identity).GetComponent<PlatformElementHandler>().Inialize(elementSelectedSingleton.Value);
            
            if(_cleanSelectionOnSpawn) {
                elementSelectedSingleton.Value = null;
                SpawnEvent.InvokeEvent();
            }
        }
    }
}