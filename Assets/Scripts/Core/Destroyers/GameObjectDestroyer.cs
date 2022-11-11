using System;
using UnityEngine;

namespace Core.Destroyers
{
    public class GameObjectDestroyer : MonoBehaviour
    {
        public GameObject target;
        public float delay;
        
        public bool destroyOnStart;

        private void Start()
        {
            if (destroyOnStart)
            {
                DestroyGameObject();
            }
        }

        public void DestroyGameObject()
        {
            Destroy(target,delay);
        }
    }
}