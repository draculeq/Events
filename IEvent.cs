namespace Deadbit.Events
{
    public interface IEvent
    {
        void RaiseEvent();
        void RegisterListener(IEventListener listener);
        void UnRegisterListener(IEventListener listener);
    }
}