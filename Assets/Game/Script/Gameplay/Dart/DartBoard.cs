using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Game.Gameplay.Dart
{
    public class DartBoard : MonoBehaviour
    {
        [SerializeField] private float dartRadius = 1.6f;
    
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnTriggerEnter(Collider other)
        {
            other.GetComponent<Rigidbody>().isKinematic = true;
        }
        
        
    }

}

