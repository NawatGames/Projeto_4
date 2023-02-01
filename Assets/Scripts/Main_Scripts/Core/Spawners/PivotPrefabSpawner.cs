using UnityEngine;

namespace Core.Spawners
{
    public class PivotPrefabSpawner : MonoBehaviour
    {
        public GameObject prefab;
        public Transform pivot;

        public bool followRotation;
        
        public GameObject Spawn()
        {
            var rotation = Quaternion.identity;
            if (followRotation)
            {
                rotation = pivot.rotation;
            }
            return Instantiate(prefab,pivot.position,rotation);
        }
    }
}