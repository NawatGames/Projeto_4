namespace HealthSystem {
    public interface IHealthSystem {
        void SetCurrentHealth(int newValue);
        void CureHealth(int cureAmount);
        void ApplyDamage(int damageToApply);
        int CurrentHealth { get; }
        int MaxHealth { get; }
    }
}