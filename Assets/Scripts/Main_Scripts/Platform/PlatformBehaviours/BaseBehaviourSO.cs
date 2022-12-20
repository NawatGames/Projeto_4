using UnityEngine;

namespace Main_Scripts.Platform.PlatformBehaviours {
   public abstract class BaseBehaviourSO: ScriptableObject {
      public abstract void StartBehaviour(GameObject platformGameObject);
      public abstract void UpdateBehaviour(GameObject platformGameObject);
      public abstract void OnCollisionEventResponse(GameObject platformGameObject, Collision2D other);
   }
}