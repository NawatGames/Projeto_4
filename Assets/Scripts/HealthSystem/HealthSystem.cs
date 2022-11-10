using EventSystem;
using UnityEngine;

namespace HealthSystem {
    public class HealthSystem : GameEventEmitter, IHealthSystem {
        [SerializeField] private int currentHealth;
        [SerializeField] private int maxHealth;
        public bool canTakeDamage = true;

        [Header("Events")]
        [SerializeField] private GameEventSO damageAppliedEvent;
        [SerializeField] private GameEventSO diedEvent;
        [SerializeField] private GameEventSO healthCuredEvent;
        
        private void Awake() {
            currentHealth = maxHealth;
        }

        public void SetCurrentHealth(int newValue) {
            currentHealth = newValue;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        }

        public void CureHealth(int cureAmount) {        
            SetCurrentHealth(currentHealth + cureAmount);
            healthCuredEvent.InvokeEvent();
        }

        public void ApplyDamage(int damageToApply) {
            if (canTakeDamage)
            {
                SetCurrentHealth(currentHealth - damageToApply);

                if (currentHealth <= 0) {
                    InvokeGameEvent(diedEvent);
                    return;
                }
                InvokeGameEvent(damageAppliedEvent);
            }
        }

        public int CurrentHealth => currentHealth;
        public int MaxHealth => maxHealth;
    }
}