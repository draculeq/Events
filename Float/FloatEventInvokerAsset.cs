using UnityEngine;

namespace Deadbit.Events
{
    [CreateAssetMenu(menuName = "Deadbit/Events/Float Event Invoker", fileName = "FloatEventInvoker")]
    public class FloatEventInvokerAsset : GenericEventInvoker<float, FloatEvent> { }
}