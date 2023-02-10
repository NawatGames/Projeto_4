using Main_Scripts.ElementSystem;
using Main_Scripts.Enemies.Shooter;
using UnityEngine;

namespace Main_Scripts.Platform.PlatformBehaviours {
    [CreateAssetMenu(fileName = "Change projectile element", menuName = "PlatformBehaviours/Change projectiles element", order = 0)]
    public class ChangeProjectileElementOnCollision : BaseBehaviourSO {
        [SerializeField] private ElementSO newBullElement;
        public override void StartBehaviour(GameObject platformGameObject) {
            
        }

        public override void UpdateBehaviour(GameObject platformGameObject) {
        }

        public override void OnCollisionEventResponse(GameObject platformGameObject, Collision2D other) {
        }

        public override void OnTriggerEventResponse(GameObject platformGameObject, Collider2D other) {
            other.gameObject.GetComponent<BulletElementHandler>().ChangeElement(newBullElement);
        }
    }
}