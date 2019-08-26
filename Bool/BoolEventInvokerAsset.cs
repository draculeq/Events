using Deadbit.Events.Generic;
using UnityEngine;

namespace Deadbit.Events.Bool
{
    [CreateAssetMenu(menuName = "Deadbit/Events/Bool Event Invoker", fileName = "BoolEventInvoker")]
    public class BoolEventInvokerAsset : GenericEventInvoker<bool, BoolEvent> { }
}