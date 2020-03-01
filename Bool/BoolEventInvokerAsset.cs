using UnityEngine;

namespace Deadbit.Events
{
    [CreateAssetMenu(menuName = "Deadbit/Events/Bool Event Invoker", fileName = "BoolEventInvoker")]
    public class BoolEventInvokerAsset : GenericEventInvoker<bool, BoolEvent> { }
}