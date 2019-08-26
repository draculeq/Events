using Deadbit.Events.Generic;
using UnityEngine;

namespace Deadbit.Events.Image
{
    [CreateAssetMenu(menuName = "Deadbit/Events/Image Event Invoker", fileName = "ImageEventInvoker")]
    public class ImageEventInvokerAsset : GenericEventInvoker<UnityEngine.UI.Image, ImageEvent> { }
}