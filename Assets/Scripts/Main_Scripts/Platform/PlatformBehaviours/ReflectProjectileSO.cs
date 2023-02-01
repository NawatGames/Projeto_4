using UnityEngine;

namespace Main_Scripts.Platform.PlatformBehaviours {
    [CreateAssetMenu(fileName = "Reflect projectile behaviour", menuName = "PlatformBehaviours/Reflect Projectile", order = 0)]
    public class ReflectProjectileSO : BaseBehaviourSO{
        public override void StartBehaviour(GameObject platformGameObject) {
        }

        public override void UpdateBehaviour(GameObject platformGameObject) {
        }

        public override void OnCollisionEventResponse(GameObject platformGameObject, Collision2D other) {
        }

        public override void OnTriggerEventResponse(GameObject platformGameObject, Collider2D other) {
            if (other.gameObject.CompareTag("Projectil")) {
                var rgb = other.gameObject.GetComponent<Rigidbody2D>();
                rgb.velocity *= -1;
            }
        }
    }
}