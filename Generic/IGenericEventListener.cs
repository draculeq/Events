namespace Deadbit.Events.Generic
{
    public interface IGenericEventListener<T>
    {
        void RaiseEventResponse(T @event);
    }
}