using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class FragileBox : Box
    {
        public GameObject ParticleEffect;
        private  bool _breakOnNextHit;
        public override void OnPickedUp()
        {
            
        }

        public override void OnDropped()
        {
        }

        public void OnCollisionEnter(Collision collision)
        {
            if (_breakOnNextHit)
            {
                Debug.Log(collision.relativeVelocity.magnitude);
                if (collision.relativeVelocity.magnitude > 6)
                {
                    Instantiate(ParticleEffect, transform.position, Quaternion.identity);
                    GameTimer.AddScore(-2);
                    Destroy(gameObject);
                }
            }
            _breakOnNextHit = true;
        }
    }
}