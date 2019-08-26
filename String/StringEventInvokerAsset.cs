using Deadbit.Events.Generic;
using UnityEngine;

namespace Deadbit.Events.String
{
    [CreateAssetMenu(menuName = "Deadbit/Events/String Event Invoker", fileName = "StringEventInvoker")]
    public class StringEventInvokerAsset : GenericEventInvoker<string, StringEvent> { }
}