using UnityEngine;

namespace Core.Destroyers
{
    public class ComponentDestroyer : MonoBehaviour
    {
        public Component target;
        public float delay;
        
        public bool destroyOnStart;

        private void Start()
        {
            if (destroyOnStart)
            {
                DestroyComponent();
            }
        }
        
        public void DestroyComponent()
        {
            Destroy(target,delay);
        }
    }
}