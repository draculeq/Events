using UnityEngine;

namespace Deadbit.Events
{
    [CreateAssetMenu(menuName = "Deadbit/Events/String Event Invoker", fileName = "StringEventInvoker")]
    public class StringEventInvokerAsset : GenericEventInvoker<string, StringEvent> { }
}