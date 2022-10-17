using UnityEngine;

namespace AttributeSystem
{
    public class GenericAttributes : MonoBehaviour, ILifeAtribute, IDamageAttribute, IMovementAttribute {
        protected float _health;

        protected float _damage;

        protected float _movementSpeed;

        public virtual void SetHealth(float newValue) {
            _health = newValue;
        }

        public virtual void ApplyDamage(float damage) {
            _health -= damage;
        }

        public virtual void SetMovementSpeed(float newValue) {
            _movementSpeed = newValue;
        }

        public virtual void SetDamageValue(float newValue) {
            _damage = newValue;
        }

        public float Health => _health;

        public float Damage => _damage;

        public float MovementSpeed => _movementSpeed;
    }
}

