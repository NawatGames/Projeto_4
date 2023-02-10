namespace HealthSystem
{
    public interface IHealthSystem
    {
        int MaxHealth { get;}
        int MinHealth { get; }
        int CurrentHealth { get; }
        bool CanTakeDamage { get; }
        void CureHealth(int cureAmount);
        void ApplyDamage(int damageToApply);
    }
}