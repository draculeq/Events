using UnityEngine;

namespace Deadbit.Events
{
    [CreateAssetMenu(menuName = "Deadbit/Events/Int Event Invoker", fileName = "IntEventInvoker")]
    public class IntEventInvokerAsset : GenericEventInvoker<int, IntEvent> { }
}