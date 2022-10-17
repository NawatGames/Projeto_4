namespace AttributeSystem {
    public interface ILifeAtribute {
        void SetHealth(float newValue);
        float Health { get; }
        void ApplyDamage(float damage);
    }
}