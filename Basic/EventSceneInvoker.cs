using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Deadbit.Events.Basic
{
    public class EventSceneInvoker : SerializedMonoBehaviour, IEvent
    {
        [BoxGroup("Status"), ReadOnly, ShowInInspector]
        private readonly List<IEventListener> listeners = new List<IEventListener>();

        [BoxGroup("Event")]
        public UnityEvent EventRaised;

        private bool raising;

        private readonly List<IEventListener> listenersToRemoveDuringRaising = new List<IEventListener>();

#pragma warning disable 649
        [BoxGroup("Tools"), SerializeField] private bool logInvoke;
#pragma warning restore 649

        [BoxGroup("Tools"), Button(ButtonSizes.Medium)]
        public void RaiseEvent()
        {
            if (logInvoke) Debug.LogFormat($"Event {name} Raised, with {listeners.Count} listeners active ", this);

            raising = true;

            for (var i = listeners.Count - 1; i >= 0; i--)
            {
                IEventListener listener = listeners[i];
                listener.RaiseEventResponse(this);
            }

            raising = false;

            if (listenersToRemoveDuringRaising.Count > 0)
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
            listeners.Add(listener);
            if (raising)
                listener.RaiseEventResponse(this);
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