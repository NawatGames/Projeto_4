using System;
using UnityEngine;

namespace Main_Scripts.Platform.PlatformBehaviours {
    [CreateAssetMenu(fileName = "Test1", menuName = "PlatformBehaviours/Test1", order = 0)]
    public class TestBehaviour1 : BaseBehaviourSO {
        public override void StartBehaviour(GameObject gameObject) {
            Debug.Log("Teste1");
        }

        public override void UpdateBehaviour(GameObject gameObject) {
            Console.Write("Update do teste 1");
        }

        public override void OnCollisionEventResponse(GameObject gameObject, Collision2D other) {
        }
    }
}