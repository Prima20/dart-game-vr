using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Gameplay.Player
{
    public class Grab : MonoBehaviour
    {
        // Start is called before the first frame update
        public GameObject myHand;
        public bool onHand = false;
        public bool isBeingTargeted = false;
        
        private Rigidbody rbd;
        private bool readyToThrow;

        void Start()
        {
            rbd = GetComponent<Rigidbody>();
        }
        
        void Update()
        {
            if (readyToThrow && Input.GetButtonDown("Fire1"))
            {
                Throw();
            }
        }

        public void OnPointerClick()
        {
            gameObject.transform.SetParent(myHand.transform, false);
            gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
            gameObject.transform.localPosition = new Vector3(0, myHand.transform.localPosition.y, 0);
            readyToThrow = true;
        }

        void Throw()
        {
            readyToThrow = false;
            gameObject.transform.SetParent(null);
            rbd.isKinematic = false;
            rbd.AddForce(Camera.main.transform.forward * 800);
        }
        
    }

}

