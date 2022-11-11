using UnityEngine;
using UnityEngine.Events;

namespace Movement_System
{
    public class WallHandler : MonoBehaviour
    {
        [SerializeField] private Transform chestPos;
        [SerializeField] private LayerMask whatIsWall;

        [SerializeField] private bool isTouchingWall;
        [SerializeField] private float checkRadius = 1;


        public UnityEvent <bool> touchWallEvent;

        private void OnDrawGizmosSelected()
        {
            Gizmos.DrawWireSphere(chestPos.position,checkRadius);
        }
        
        private void Update()
        {
            var wasTouchingWall = isTouchingWall;
            isTouchingWall = Physics2D.OverlapCircle(chestPos.position,checkRadius,whatIsWall);

            if(wasTouchingWall && !isTouchingWall)
            {
                touchWallEvent.Invoke(false);
            }
            if(!wasTouchingWall && isTouchingWall)
            {
                touchWallEvent.Invoke(true);
            }
        }
    }
}