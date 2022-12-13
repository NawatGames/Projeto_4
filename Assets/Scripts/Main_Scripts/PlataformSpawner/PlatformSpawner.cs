using EventSystem.SimpleEvents;
using UnityEngine;

namespace Main_Scripts.PlataformSpawner {
    public class PlatformSpawner : MonoBehaviour {
        public Vector2Event eventToListen;
        [SerializeField] private GameObject platformPrefab;

        private void OnEnable() {
            eventToListen.SubscribeUnityEvent(Teste);
        }

        private void OnDisable() {
            eventToListen.UnsubscribeUnityEvent(Teste);
        }

        public void Teste(Vector2 vector2) {
            //todo: Não está rotacionando devidamente
            var dir = vector2.normalized;

            Instantiate(platformPrefab, vector2, Quaternion.Euler(dir));
        }
    }
}