using UnityEngine;

namespace Main_Scripts.Platform.PlatformBehaviours {
    [CreateAssetMenu(fileName = "Test1", menuName = "PlatformBehaviours/Test1", order = 0)]
    public class TestBehaviour1 : BaseBehaviourSO {
        public override void StartBehaviour(GameObject platformGameObject) {
            Debug.Log("Teste1");
        }

        public override void UpdateBehaviour(GameObject platformGameObject) {
            Debug.Log("Update do teste 1");
        }

        public override void OnCollisionEventResponse(GameObject platformGameObject, Collision2D other) {
            Debug.Log("Poxa, vc bateu na plataforma 1 :(");

            var rgb = other.gameObject.GetComponent<Rigidbody2D>();
            rgb.AddForce(Vector2.up * 1000, ForceMode2D.Force);
        }
    }
}