using System;
using System.Collections;
using System.Collections.Generic;
using Game.Gameplay.UI;
using UnityEditor;
using UnityEngine;

namespace Game.Gameplay.Dart
{
    public class DartBoard : MonoBehaviour
    {
        [SerializeField] private ScoreUIController scoreUi;

        private void OnTriggerEnter(Collider other)
        {
            other.GetComponent<Rigidbody>().isKinematic = true;
            scoreUi.SetScore(CountScore(transform.position, other.transform.position));
        }

        double CountScore(Vector3 ownPos, Vector3 otherPos)
        {
            return Vector3.Distance(ownPos, otherPos);
        }
        
        
    }

}

