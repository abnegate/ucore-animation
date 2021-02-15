using UnityEngine;
using UCore.Events;

namespace UCore.Animation
{
    public class AnimationEventTrigger : MonoBehaviour
    {
        public UnityStringEvent onFired;

        public void OnTriggerAnimationEvent(string parameter)
        {
            onFired.Invoke(parameter);
        }
    }
}
