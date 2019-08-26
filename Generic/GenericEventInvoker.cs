using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Deadbit.Events.Generic
{
    public abstract class GenericEventInvoker<T, TEvent> : SerializedScriptableObject, IGenericEvent<T> where TEvent : UnityEvent<T>
    {
        [BoxGroup("Status"), ShowInInspector, ReadOnly]
        private readonly List<IGenericEventListener<T>> listeners = new List<IGenericEventListener<T>>();
        private readonly List<IEventListener> simpleListeners = new List<IEventListener>();

        [BoxGroup("Event")] public TEvent EventRaised;
        [BoxGroup("Event")] public TEvent BeforeEventRaised;

#pragma warning disable 649
        [BoxGroup("Tools"), SerializeField] private bool logInvoke;
#pragma warning restore 649

        private bool raising;
        private T param;

        private readonly List<IEventListener> simpleListenersToRemoveDuringRaising = new List<IEventListener>();
        private readonly List<IGenericEventListener<T>> listenersToRemoveDuringRaising = new List<IGenericEventListener<T>>();

        void OnEnable()
        {
            raising = false;
        }

        [FoldoutGroup("Tools"), Button(ButtonSizes.Medium)]
        public void RaiseEvent(T param)
        {
            if (logInvoke) Debug.LogFormat($"Event {name} Raised, with {listeners.Count} listeners active ", this);

            BeforeEventRaised.Invoke(param);

            raising = true;
            this.param = param;

            for (int i = simpleListeners.Count - 1; i >= 0; i--)
            {
                simpleListeners[i].RaiseEventResponse(this);
            }

            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].RaiseEventResponse(param);
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

            if (simpleListenersToRemoveDuringRaising.Count > 0)
            {
                for (int i = 0; i < simpleListenersToRemoveDuringRaising.Count; i++)
                {
                    simpleListeners.Remove(simpleListenersToRemoveDuringRaising[i]);
                }
                simpleListenersToRemoveDuringRaising.Clear();
            }

            EventRaised.Invoke(param);
        }

        public void RegisterListener(IGenericEventListener<T> listener)
        {
            if (!listeners.Contains(listener))
            {
                listeners.Add(listener);
                if (raising)
                {
                    listener.RaiseEventResponse(param);
                }
            }
        }

        public void UnRegisterListener(IGenericEventListener<T> listener)
        {
            if (raising)
                listenersToRemoveDuringRaising.Add(listener);
            else
                listeners.Remove(listener);
        }

        [FoldoutGroup("Tools"), Button(ButtonSizes.Medium)]
        public void RaiseEvent()
        {
            RaiseEvent(default);
        }
        
        public void RegisterListener(IEventListener listener)
        {
            if (!simpleListeners.Contains(listener))
            {
                simpleListeners.Add(listener);
                if (raising)
                {
                    listener.RaiseEventResponse(this);
                }
            }
        }

        public void UnRegisterListener(IEventListener listener)
        {
            if (raising)
                simpleListenersToRemoveDuringRaising.Add(listener);
            else
                simpleListeners.Remove(listener);
        }
    }
}
