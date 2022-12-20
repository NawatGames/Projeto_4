using UnityEngine;

namespace Main_Scripts.Platform.PlatformBehaviours {
   public abstract class BaseBehaviourSO: ScriptableObject {
      public abstract void StartBehaviour(GameObject gameObject);
      public abstract void UpdateBehaviour(GameObject gameObject);
      public abstract void OnCollisionEventResponse(Collision2D other);
   }
}