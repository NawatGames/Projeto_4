using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GroundHandler : MonoBehaviour
{
    [SerializeField] private Transform feetPos;
    [SerializeField] private LayerMask whatIsGround;

    public bool isGrounded;
    [SerializeField] float checkRadius = 1;

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
        isGrounded = Physics2D.OverlapCircle(feetPos.position,checkRadius,whatIsGround);
    }

    // public bool GetIsGrounded()
    // {
    //     return this.isGrounded;
    // }
}
