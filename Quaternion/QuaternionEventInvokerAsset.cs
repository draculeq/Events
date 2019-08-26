using Deadbit.Events.Generic;
using UnityEngine;

namespace Deadbit.Events.Quaternion
{
    [CreateAssetMenu(menuName = "Deadbit/Events/Quaternion Event Invoker", fileName = "QuaternionEventInvoker")]
    public class QuaternionEventInvokerAsset : GenericEventInvoker<UnityEngine.Quaternion, QuaternionEvent> { }
}