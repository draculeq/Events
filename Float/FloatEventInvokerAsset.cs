using Deadbit.Events.Generic;
using UnityEngine;

namespace Deadbit.Events.Float
{
    [CreateAssetMenu(menuName = "Deadbit/Events/Float Event Invoker", fileName = "FloatEventInvoker")]
    public class FloatEventInvokerAsset : GenericEventInvoker<float, FloatEvent> { }
}