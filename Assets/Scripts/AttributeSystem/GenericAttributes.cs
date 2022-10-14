using System;
using UnityEditor.Timeline.Actions;

namespace AttributeSystem
{
    public abstract class GenericAttributes 
    {
        protected float _health;

        protected float _damage;

        protected float _movementSpeed;

        public virtual void SetHealth(float newValue)
        {
            _health = newValue;
            //Invoker();
        }

        public virtual void ApplyDamage(float damage)
        {
            _health -= damage;
            //invocar evento
        }

        public virtual void SetMovementSpeed(float newValue)
        {
            _movementSpeed = newValue;
        }

        public virtual void SetDamageValue(int newValue)
        {
            _damage = newValue;
        }

        public float Health => _health;

        public float Damage => _damage;

        public float MovementSpeed => _movementSpeed;
    }
}

