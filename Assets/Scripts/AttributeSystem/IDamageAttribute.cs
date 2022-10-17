namespace AttributeSystem {
    public interface IDamageAttribute {
        void SetDamageValue(float newValue);
        float Damage { get; }
    }
}