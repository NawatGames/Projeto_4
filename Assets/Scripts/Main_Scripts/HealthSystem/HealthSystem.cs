using EventSystem.SimpleEvents;
using Main_Scripts.EventSystem.SimpleEvents;
using UnityEngine;

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
            if (canTakeDamage)
            {
                SetCurrentHealth(currentHealth - damageToApply);
                if (currentHealth <= 0) {
                    diedEvent?.InvokeEvent();
                    return;
                }
                tookDamageEvent?.InvokeEvent();
            }
            else tookDamageWhileInvincibleEvent?.InvokeEvent();
        }

        // Interface stuff
        public int CurrentHealth => currentHealth;
        public int MaxHealth => maxHealth;
        int IHealthSystem.MinHealth => minHealth;
        bool IHealthSystem.CanTakeDamage => canTakeDamage;
    }
}