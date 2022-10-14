using EventSystem;

namespace AttributeSystem
{
    public abstract class GenericAttributes : GameEventEmitter
    {
        public GameEventSO _healthChangedEvent;
        public GameEventSO _damageChangedEvent;
        public GameEventSO _movementSpeedChangedEvent;
        
        protected float _health;

        protected float _damage;

        protected float _movementSpeed;

        public virtual void SetHealth(float newValue)
        {
            _health = newValue;
            InvokeGameEvent(_healthChangedEvent);
            
        }

        public virtual void ApplyDamage(float damage)
        {
            _health -= damage;
            InvokeGameEvent(_healthChangedEvent);

        }

        public virtual void SetMovementSpeed(float newValue)
        {
            _movementSpeed = newValue;
            InvokeGameEvent(_movementSpeedChangedEvent);

        }

        public virtual void SetDamageValue(int newValue)
        {
            _damage = newValue;
            InvokeGameEvent(_damageChangedEvent);
        }

        public float Health => _health;

        public float Damage => _damage;

        public float MovementSpeed => _movementSpeed;
    }
}

