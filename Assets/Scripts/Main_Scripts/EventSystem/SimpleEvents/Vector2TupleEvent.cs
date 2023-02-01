using UnityEngine;

namespace EventSystem.SimpleEvents {
    [CreateAssetMenu(menuName = "simple event/Vector2TupleEvent Event",fileName = "new Vector2 Tuple event")]
    public class Vector2TupleEvent : SimpleEventSO<(Vector2, Vector2)> {
        
    }
}