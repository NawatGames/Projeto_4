using System;
using UnityEngine;

namespace Main_Scripts.Platform.PlatformBehaviours {
    [CreateAssetMenu(fileName = "Test2", menuName = "PlatformBehaviours/Test2", order = 0)]
    public class TestBehaviour2 : BaseBehaviourSO {
        public override void StartBehaviour(GameObject platformGameObject) {
        }

        public override void UpdateBehaviour(GameObject platformGameObject) {
        }

        public override void OnCollisionEventResponse(GameObject platformGameObject, Collision2D other) {
            Debug.Log("Poxa, vc bateu na plataforma :(");
        }
    }
}