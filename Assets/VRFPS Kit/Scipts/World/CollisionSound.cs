
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRFPSKit
{
    public class CollisionSound : MonoBehaviour
    {
        public AudioSource source;

        private void OnCollisionEnter(Collision other)
        {
            source.Play(); //TODO works on client?
        }
    }
}