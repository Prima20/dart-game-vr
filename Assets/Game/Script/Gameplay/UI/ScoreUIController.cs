using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay.UI
{
    public class ScoreUIController : MonoBehaviour
    {
        [SerializeField] private Text scoreText;
        private const string StringGreat = "Great";
        private const string StringGood = "Good";
        private const string StringBetter = "Better";

        string DetermineResult(double score)
        {
            if (score < 0.3)
            {
                return StringGreat;
            }
            else if (score > 0.3 && score < 0.7)
            {
                return StringGood;
            }
            else
            {
                return StringBetter;
            }
        }

        public void SetScore(double score)
        {
            scoreText.text = DetermineResult(score);
        }
    }

}

