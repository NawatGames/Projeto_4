using UnityEngine;

namespace Main_Scripts.Platform.PlatformBehaviours {
    [CreateAssetMenu(fileName = "Cant be above", menuName = "PlatformBehaviours/Cant be above", order = 0)]
    public class CantBeAbove: BaseBehaviourSO {
        public override void StartBehaviour(GameObject platformGameObject) {
            platformGameObject.GetComponent<Collider2D>().isTrigger = true;
        }

        public override void UpdateBehaviour(GameObject platformGameObject) {
        }

        public override void OnCollisionEventResponse(GameObject platformGameObject, Collision2D other) {
        }

        public override void OnTriggerEventResponse(GameObject platformGameObject, Collider2D other) {
        }
    }
}