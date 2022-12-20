using System;
using UnityEngine;

namespace Main_Scripts.Platform.PlatformBehaviours {
    [CreateAssetMenu(fileName = "Test2", menuName = "PlatformBehaviours/Test2", order = 0)]
    public class TestBehaviour2 : BaseBehaviourSO {
        public override void StartBehaviour(GameObject gameObject) {
            Debug.Log("Teste2");
        }

        public override void UpdateBehaviour(GameObject gameObject) {
            Console.Write("Update do teste 2");
        }

        public override void OnCollisionEventResponse(GameObject gameObject, Collision2D other) {
        }
    }
}