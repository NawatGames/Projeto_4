
namespace EventSystem {
    public abstract class GameEventEmitter {
        public GameEventSO eventToEmmit;

        public void EmitEvent() {
            eventToEmmit.InvokeEvent();
        }
    }
}