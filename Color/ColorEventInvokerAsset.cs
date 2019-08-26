using Deadbit.Events.Generic;
using UnityEngine;

namespace Deadbit.Events.Color
{
    [CreateAssetMenu(menuName = "Deadbit/Events/Color Event Invoker", fileName = "ColorEventInvoker")]
    public class ColorEventInvokerAsset : GenericEventInvoker<UnityEngine.Color, ColorEvent> { }
}