using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Deadbit.Events
{
    public class EventSceneListener : SerializedMonoBehaviour, IEventListener
    {
        [BoxGroup("Event")]
        public IEvent Event;

        [BoxGroup("Event")]
        public UnityEvent Response;

        [FoldoutGroup("Tools")]
        public bool logRaise;

        public void OnEnable()
        {
            Event?.RegisterListener(this);
        }

        public void OnDisable()
        {
            Event?.UnRegisterListener(this);
        }

        [FoldoutGroup("Tools"), Button("Raise Event Response", ButtonSizes.Medium)]
        public void RaiseEventResponse()
        {
            RaiseEventResponse(default);
        }

        public void RaiseEventResponse(IEvent evt)
        {
            if (!enabled)
                return;

            if (logRaise) Debug.LogFormat(this, "Event Response receive on {0}", name);
            Response.Invoke();
        }
    }
}