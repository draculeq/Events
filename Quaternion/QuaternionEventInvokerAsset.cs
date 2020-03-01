using UnityEngine;

namespace Deadbit.Events
{
    [CreateAssetMenu(menuName = "Deadbit/Events/Quaternion Event Invoker", fileName = "QuaternionEventInvoker")]
    public class QuaternionEventInvokerAsset : GenericEventInvoker<UnityEngine.Quaternion, QuaternionEvent> { }
}