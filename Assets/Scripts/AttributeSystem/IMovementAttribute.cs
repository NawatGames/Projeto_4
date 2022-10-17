namespace AttributeSystem {
    public interface IMovementAttribute {
        void SetMovementSpeed(float newValue);
        float MovementSpeed { get; }
    }
}