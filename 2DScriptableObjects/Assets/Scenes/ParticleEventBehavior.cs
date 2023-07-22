using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ParticleEventBehavior : MonoBehaviour
{

    public UnityEvent particleHit;

    private void OnParticleCollision()
    {
        particleHit.Invoke();
    }
}
