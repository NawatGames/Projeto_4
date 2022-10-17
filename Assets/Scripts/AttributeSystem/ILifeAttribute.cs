namespace AttributeSystem {
    public interface ILifeAttribute {
        void SetHealth(float newValue);
        float Health { get; }
        void ApplyDamage(float damage);
    }
}