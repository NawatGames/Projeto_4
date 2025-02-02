using EventSystem.SimpleEvents;
using Main_Scripts.EventSystem.SimpleEvents;
using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace HealthSystem {
    public class HealthSystem : MonoBehaviour, IHealthSystem {
        [SerializeField] private int maxHealth = 100;
        [SerializeField] private int minHealth = 0;
        [SerializeField] private int currentHealth;
        public bool canTakeDamage = true;

        [Header("Events")]
        [SerializeField] private NoTypeGameEvent tookDamageEvent;
        [SerializeField] private NoTypeGameEvent diedEvent;
        [SerializeField] private NoTypeGameEvent curedHealthEvent;
        [SerializeField] private NoTypeGameEvent tookDamageWhileInvincibleEvent;
        [SerializeField] private IntegerEvent healthChangedEvent;

        public GameObject toDestroy = null;

        public UnityEvent DiedUnityEvent;

        private void Awake() {
            currentHealth = maxHealth;
        }

        public void SetCurrentHealth(int newHealthValue) {
            currentHealth = newHealthValue;
            currentHealth = Mathf.Clamp(currentHealth, minHealth, maxHealth);
            healthChangedEvent?.InvokeEvent(currentHealth);
        }

        public void CureHealth(int cureAmount) {        
            SetCurrentHealth(currentHealth + cureAmount);
            curedHealthEvent?.InvokeEvent();
        }

        public void ApplyDamage(int damageToApply) {
            Debug.Log("Can take damage: " + canTakeDamage);
            if (canTakeDamage)
            {
                SetCurrentHealth(currentHealth - damageToApply);
                if (currentHealth <= 0) {
                    diedEvent?.InvokeEvent();
                    DiedUnityEvent.Invoke();
                    if (toDestroy != null) StartCoroutine(destroyCountdown(3f, toDestroy));
                    else StartCoroutine(destroyCountdown(3f));
                    return;
                }
                tookDamageEvent?.InvokeEvent();
            }
            else tookDamageWhileInvincibleEvent?.InvokeEvent();
        }

        private IEnumerator destroyCountdown(float delay, GameObject toDestroy){
            yield return new WaitForSeconds(delay);
            Destroy(toDestroy);
        }

        private IEnumerator destroyCountdown(float delay){
            yield return new WaitForSeconds(delay);
            Destroy(gameObject);
        }

        // Interface stuff
        public int CurrentHealth => currentHealth;
        public int MaxHealth => maxHealth;
        int IHealthSystem.MinHealth => minHealth;
        bool IHealthSystem.CanTakeDamage => canTakeDamage;
    }
}