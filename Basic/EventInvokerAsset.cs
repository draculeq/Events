using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Deadbit.Events.Basic
{
    [CreateAssetMenu(menuName = "Deadbit/Events/Event Invoker", fileName = "Event Invoker")]
    public class EventInvokerAsset : SerializedScriptableObject, IEvent
    {
        [BoxGroup("Status"), ShowInInspector]
        private readonly List<IEventListener> listeners = new List<IEventListener>();

        [BoxGroup("Event")] public UnityEvent EventRaised;
        [BoxGroup("Event")] public UnityEvent BeforeEventRaised;

        private bool raising = false;
        private readonly List<IEventListener> listenersToRemoveDuringRaising = new List<IEventListener>();

#pragma warning disable 649
        [BoxGroup("Tools"), SerializeField] private bool logInvoke;
#pragma warning restore 649

        [BoxGroup("Tools"), Button(ButtonSizes.Medium)]
        public void RaiseEvent()
        {
            if (logInvoke) Debug.LogFormat($"Event {name} Raised, with {listeners.Count} listeners active ", this);

            BeforeEventRaised.Invoke();

            raising = true;

            for (int i = 0; i < listeners.Count; i++)
            {
                listeners[i].RaiseEventResponse(this);
            }

            raising = false;

            if (listenersToRemoveDuringRaising.Any())
            {
                for (int i = 0; i < listenersToRemoveDuringRaising.Count; i++)
                {
                    listeners.Remove(listenersToRemoveDuringRaising[i]);
                }
                listenersToRemoveDuringRaising.Clear();
            }
            EventRaised.Invoke();
        }

        public void RegisterListener(IEventListener listener)
        {
            if (!listeners.Contains(listener))
            {
                listeners.Add(listener);
                if (raising)
                    listener.RaiseEventResponse(this);
            }
        }

        public void UnRegisterListener(IEventListener listener)
        {
            if (raising)
                listenersToRemoveDuringRaising.Add(listener);
            else
                listeners.Remove(listener);
        }
    }
}