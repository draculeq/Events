using UnityEngine;

namespace Deadbit.Events
{
    [CreateAssetMenu(menuName = "Deadbit/Events/Image Event Invoker", fileName = "ImageEventInvoker")]
    public class ImageEventInvokerAsset : GenericEventInvoker<UnityEngine.UI.Image, ImageEvent> { }
}