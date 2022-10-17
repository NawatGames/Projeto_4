using EventSystem;
using UnityEngine;

namespace AttributeSystem {
    public class LifeController : GameEventEmitter {
        private float _currentHealth;
        private ILifeAttribute _lifeAttribute;
        private GameEventSO _onDiedEvent;
        private GameEventSO _onDamageAppliedEvent;

        private void Awake() {
            _lifeAttribute = GetComponent<ILifeAttribute>();
        }

        public void ApplyDamage(float damageToApply) {
            SetHealthValue(_currentHealth - damageToApply);
            
            if (_currentHealth <= 0) {
                InvokeGameEvent(_onDiedEvent);
                return;
            }
            
            InvokeGameEvent(_onDamageAppliedEvent);
        }

        private void SetHealthValue(float newValue) {
            _currentHealth = Mathf.Clamp(newValue, 0, 100);
            _lifeAttribute.SetHealth(_currentHealth);
        }
        
    }
}