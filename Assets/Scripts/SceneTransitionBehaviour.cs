using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LocalMultiplayerGame
{
    public class SceneTransitionBehaviour : MonoBehaviour
    {
        [SerializeField] private int sceneToTransitionTo;
        [SerializeField] private SceneTransitionCondition sceneTransitionCondition;

        private int playerCollisionCount = 0;

        public int PlayerCollisionCount
        {
            get => playerCollisionCount;
            set
            {
                playerCollisionCount = value;
                switch (sceneTransitionCondition)
                {
                    case SceneTransitionCondition.OnePlayerTouch:
                        if (playerCollisionCount >= 1)
                        {
                            SceneManager.LoadScene(sceneToTransitionTo);
                        }

                        break;
                    case SceneTransitionCondition.TwoPlayersTouch:
                        if (playerCollisionCount == 2)
                        {
                            SceneManager.LoadScene(sceneToTransitionTo);
                        }

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}