using UnityEngine;

namespace Main_Scripts.Platform.PlatformBehaviours {
    [CreateAssetMenu(fileName = "Test1", menuName = "PlatformBehaviours/Test1", order = 0)]
    public class SuperJump : BaseBehaviourSO {
        public override void StartBehaviour(GameObject platformGameObject) {
        }

        public override void UpdateBehaviour(GameObject platformGameObject) {
        }

        public override void OnCollisionEventResponse(GameObject platformGameObject, Collision2D other) {
            Debug.Log("Poxa, vc bateu na plataforma 1 :(");

            var rgb = other.gameObject.GetComponent<Rigidbody2D>();
            rgb.AddForce(Vector2.up * 1000, ForceMode2D.Force);
        }

        public override void OnTriggerEventResponse(GameObject platformGameObject, Collider2D  other) {
        }
    }
}