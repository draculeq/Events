using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Deadbit.Events
{
    public abstract class GenericEventSceneListener<T, TEvent> : SerializedMonoBehaviour, IGenericEventListener<T> where TEvent : UnityEvent<T>
    {
        [BoxGroup("Event")]
        public IGenericEvent<T> Event;

        [BoxGroup("Event")]
        public TEvent Response;

        [FoldoutGroup("Tools")]
        public bool logRaise;

        public void OnEnable()
        {
            Event.RegisterListener(this);
        }

        public void OnDisable()
        {
            Event.UnRegisterListener(this);
        }

        protected virtual bool MeetCustomRaiseConditions(T param)
        {
            return true;
        }

        public void OnEventRaised(T param)
        {
            if (!enabled || !MeetCustomRaiseConditions(param))
                return;

            if (logRaise) Debug.LogFormat(this, "Event Response receive on {0}", name);
            Response.Invoke(param);
        }

        [FoldoutGroup("Tools"), Button("Raise Event Response", ButtonSizes.Medium)]
        public void RaiseEventResponse(T param)
        {
            OnEventRaised(param);
        }

        [FoldoutGroup("Tools"), Button("Raise Event Response", ButtonSizes.Medium)]
        public void RaiseEventResponse()
        {
            OnEventRaised(default);
        }
    }
}