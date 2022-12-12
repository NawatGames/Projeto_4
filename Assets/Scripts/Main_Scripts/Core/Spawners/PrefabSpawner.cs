using UnityEngine;

namespace Core.Spawners
{
    public class PrefabSpawner : MonoBehaviour
    {
        public GameObject prefab;

        public GameObject Spawn()
        {
            return Instantiate(prefab);
        }
    }
}