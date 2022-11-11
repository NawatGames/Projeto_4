using UnityEngine;

namespace Core
{
    public class Singleton<T> : MonoBehaviour
    {
        public static T instance;
        
    }
}