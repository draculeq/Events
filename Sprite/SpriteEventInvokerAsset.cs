using UnityEngine;

namespace Deadbit.Events
{
    [CreateAssetMenu(menuName = "Deadbit/Events/Sprite Event Invoker", fileName = "SpriteEventInvoker")]
    public class SpriteEventInvokerAsset : GenericEventInvoker<UnityEngine.Sprite, SpriteEvent> { }
}