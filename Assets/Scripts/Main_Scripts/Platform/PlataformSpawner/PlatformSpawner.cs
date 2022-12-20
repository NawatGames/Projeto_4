using EventSystem;
using EventSystem.SimpleEvents;
using Main_Scripts.Platform;
using Main_Scripts.SingletonsSO;
using UnityEngine;

namespace Main_Scripts.PlataformSpawner {
    public class PlatformSpawner : MonoBehaviour {
        public Vector2Event eventToListen;
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

        public void SpawnPlatform(Vector2 vector2) {
            if (elementSelectedSingleton.Value == null)
                return;
            
            //todo: Não está rotacionando devidamente
            var dir = vector2.normalized;
            Instantiate(platformPrefab, vector2, Quaternion.Euler(dir)).GetComponent<PlatformElementHandler>().Inialize(elementSelectedSingleton.Value);
            
            if(_cleanSelectionOnSpawn) {
                elementSelectedSingleton.Value = null;
                SpawnEvent.InvokeEvent();
            }
        }
    }
}