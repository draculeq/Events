using Deadbit.Events.Generic;
using UnityEngine;

namespace Deadbit.Events.Sprite
{
    [CreateAssetMenu(menuName = "Deadbit/Events/Sprite Event Invoker", fileName = "SpriteEventInvoker")]
    public class SpriteEventInvokerAsset : GenericEventInvoker<UnityEngine.Sprite, SpriteEvent> { }
}