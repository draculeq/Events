namespace Deadbit.Events
{
    public interface IGenericEventListener<T>
    {
        void RaiseEventResponse(T @event);
    }
}