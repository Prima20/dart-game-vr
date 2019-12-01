using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Game.Gameplay.Box
{
    public class Box : MonoBehaviour
    {
        private bool isTarget = false;
        private Rigidbody rbd;

        private void Start()
        {
            rbd = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if (Input.GetButtonDown("Fire1") && isTarget)
            {
                Debug.Log("Is Force!");
                rbd.AddForce(Vector3.up * 500f);
            }
        }

        public void OnPointerEnter()
        {
            Debug.Log("Pointer Enter");
            isTarget = true;
        }

        public void OnPointerLeave()
        {
            Debug.Log("Pointer Leave");
            isTarget = false;
        }
    }

}

