using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Gameplay.Player
{
    public class Grab : MonoBehaviour
    {
        // Start is called before the first frame update
        private GameObject arrow;
        public GameObject myHand;
        public bool onHand = false;

        private Rigidbody rbd;
        void Start()
        {
            rbd = GetComponent<Rigidbody>();
            arrow = this.gameObject;
        }

        // Update is called once per frame
        private void Update()
        {
            GrabItem();
        }

        public void GrabItem()
        {
            if (Input.GetButtonDown("Fire1") && onHand == false)
            {
                arrow.transform.rotation = Quaternion.Euler(-90, 0, 47);
                arrow.transform.SetParent(myHand.transform);
                arrow.transform.localPosition = new Vector3(0, myHand.transform.localPosition.y, 0);
                onHand = true;
            }
            else if (Input.GetButtonDown("Fire1") && onHand)
            {
                Throw();
            }
        }

        void Throw()
        {
            arrow.transform.SetParent(null);
            rbd.isKinematic = false;
            rbd.AddForce(Vector3.forward* 500);
        }
    }

}

