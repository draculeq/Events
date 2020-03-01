using UnityEngine;

namespace Deadbit.Events
{
    [CreateAssetMenu(menuName = "Deadbit/Events/Color Event Invoker", fileName = "ColorEventInvoker")]
    public class ColorEventInvokerAsset : GenericEventInvoker<UnityEngine.Color, ColorEvent> { }
}