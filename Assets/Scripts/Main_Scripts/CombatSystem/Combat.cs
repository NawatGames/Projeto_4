using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    [SerializeField] private List<DangerousObject> objectsThatSufferFrom;
    [SerializeField] private GameObject toDestroyWhenDie = null;
    private HealthSystem.HealthSystem health;

    private void Awake()
    {
        health = gameObject.GetComponent<HealthSystem.HealthSystem>();
        health.toDestroy = toDestroyWhenDie;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        TrySufferDamage(other.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        TrySufferDamage(other.gameObject);
    }

    private void TrySufferDamage(GameObject objectThatCollidedWith)
    {
        foreach (var harmfulObject in objectsThatSufferFrom)
        {
            if (objectThatCollidedWith.tag == harmfulObject.objectThatDealsDamage.tag)
            {
                health.ApplyDamage(harmfulObject.damageReceivedByObject);
            }
        }
    }

    [System.SerializableAttribute]
    private class DangerousObject
    {
        [SerializeField] public GameObject objectThatDealsDamage;
        [SerializeField] public int damageReceivedByObject;

    }
}


