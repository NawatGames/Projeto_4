using EventSystem;
using Main_Scripts.EventSystem.SimpleEvents;
using UnityEngine;

namespace HealthSystem {
    public class HealthSystem : MonoBehaviour, IHealthSystem {
        [SerializeField] private int currentHealth;
        [SerializeField] private int maxHealth;
        public bool canTakeDamage = true;

        [Header("Events")]
        [SerializeField] private NoTypeGameEvent damageAppliedEvent;
        [SerializeField] private NoTypeGameEvent diedEvent;
        [SerializeField] private NoTypeGameEvent healthCuredEvent;
        
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
                    diedEvent.InvokeEvent();
                    return;
                }
                damageAppliedEvent.InvokeEvent();
            }
        }

        public int CurrentHealth => currentHealth;
        public int MaxHealth => maxHealth;
    }
}