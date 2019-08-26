namespace Deadbit.Events
{
    public interface IEventListener
    {
        void RaiseEventResponse(IEvent @event);
    }
}