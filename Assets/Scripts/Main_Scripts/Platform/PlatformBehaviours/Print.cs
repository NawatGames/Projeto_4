using UnityEngine;

namespace Main_Scripts.Platform.PlatformBehaviours {
    [CreateAssetMenu(fileName = "Print", menuName = "PlatformBehaviours/Print", order = 0)]
    public class Print : BaseBehaviourSO {
        public override void StartBehaviour(GameObject platformGameObject) {
        }

        public override void UpdateBehaviour(GameObject platformGameObject) {
        }

        public override void OnCollisionEventResponse(GameObject platformGameObject, Collision2D other) {
            Debug.Log("Poxa, vc bateu na plataforma :(");
        }

        public override void OnTriggerEventResponse(GameObject platformGameObject, Collider2D other) {
            Debug.Log("Poxa, vc bateu na plataforma :(");
        }
    }
}