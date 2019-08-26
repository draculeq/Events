using Deadbit.Events.Generic;
using UnityEngine;

namespace Deadbit.Events.Int
{
    [CreateAssetMenu(menuName = "Deadbit/Events/Int Event Invoker", fileName = "IntEventInvoker")]
    public class IntEventInvokerAsset : GenericEventInvoker<int, IntEvent> { }
}