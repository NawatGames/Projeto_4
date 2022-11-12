using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GroundHandler : MonoBehaviour
{
    [SerializeField] private Transform feetPos;
    [SerializeField] private LayerMask whatIsGround;

    [SerializeField] bool isGrounded;
    [SerializeField] float checkRadius = 1;


    public UnityEvent <bool> touchGroundEvent;

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(feetPos.position,checkRadius);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var wasGrounded = isGrounded;
        isGrounded = Physics2D.OverlapCircle(feetPos.position,checkRadius,whatIsGround);

        if(wasGrounded && !isGrounded)
        {
            touchGroundEvent.Invoke(false);
        }
        if(!wasGrounded && isGrounded)
        {
            touchGroundEvent.Invoke(true);
        }
    }

    
}
