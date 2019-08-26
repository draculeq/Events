using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Deadbit.Events
{
    public class UnityEventsList : MonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] private List<UnityEvent> events;

        [BoxGroup("Tools"), SerializeField]
        private bool logRaise;
#pragma warning restore 649

        [Button(ButtonSizes.Medium)]
        public void Execute()
        {
            if (logRaise)
                Debug.Log("Events List Execution Started", this);

            for (int i = 0; i < events.Count; i++)
            {
                events[i].Invoke();
            }
        }
    }
}