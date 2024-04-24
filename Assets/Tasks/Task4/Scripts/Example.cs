using System.Collections.Generic;
using UnityEngine;

namespace TaskFour
{
    public class Example : MonoBehaviour
    {
        [SerializeField] private WinConditionSetup _winConditionSetup;

        [SerializeField] private LayerMask _layer;

        [SerializeField] private List<Ball> _ballsOneColor = new List<Ball>();
        [SerializeField] private List<Ball> _ballsTwoColor = new List<Ball>();
        [SerializeField] private List<Ball> _ballsThreeColor = new List<Ball>();

        [SerializeField] private List<Ball> _balls = new List<Ball>();

        private void Awake()
        {
            _winConditionSetup.SetConditionVictory(new AllBalls(_balls));
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _winConditionSetup?.PopBall(_layer);
            }
        }

        public void EnterModeAllBalls() 
        {
            _winConditionSetup.SetConditionVictory(new AllBalls(_balls));
            Debug.Log("Выбран режим: все шарики!");
        }

        public void EnterModeOneColor()
        {
            _winConditionSetup.SetConditionVictory(new BallsOneColor(_ballsOneColor, _ballsTwoColor, _ballsThreeColor));
            Debug.Log("Выбран режим: один цвет!");
        }
    }
}
