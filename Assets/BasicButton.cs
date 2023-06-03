using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{   
    public abstract class BasicButton : MonoBehaviour
    {
        protected Vector3 originalPosition;

        public bool IsPushed = false;
        public float PushDistance = 0.07f; // distance to push down in world units
        public float PushDuration = 0.7f; // duration of the push animation in seconds
        public static event System.Action OnPushed;
        
        private void Start()
        {
            // Store the original position of the GameObject
            originalPosition = transform.position;
        }

        public virtual void OnPush()
        {
            
            OnPushed?.Invoke();
            PlaySound();

            // Move the GameObject down by a small amount
            StartCoroutine(PushDownAndUp());
        }

        public virtual void PlaySound()
        {
        }

        public IEnumerator PushDownAndUp()
        {
            Vector3 targetPosition = originalPosition - new Vector3(0, 0, PushDistance);

            IsPushed = true;
            
            // Push the button down
            float t = 0;
            while (t < PushDuration)
            {
                
                t += Time.fixedDeltaTime;
                transform.position = Vector3.Lerp(originalPosition, targetPosition, t / PushDuration);
                yield return null;
            }

            // Push the button back up
            t = 0;
            while (t < PushDuration)
            {
                t += Time.deltaTime;
                transform.position = Vector3.Lerp(targetPosition, originalPosition, t / PushDuration);
                yield return null;
            }
            transform.position = originalPosition; // Ensure the GameObject returns to its original position
            IsPushed = false;
        }
    }
}