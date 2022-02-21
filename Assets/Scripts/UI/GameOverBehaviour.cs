using System;
using LocalMultiplayerGame.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace LocalMultiplayerGame.UI
{
    public class GameOverBehaviour : MonoBehaviour
    {
        [SerializeField] private GameObject gameOverContent;
        [SerializeField] private Button restartButton;

        public void Start()
        {
            // Reset time scale at the start of the scene because it doesn't work in the Restart function
            // for some reason, unity is stupid
            Time.timeScale = 1f;
        }

        public void TriggerGameOver()
        {
            Time.timeScale = 0f;
            gameOverContent.SetActive(true);
            restartButton.Select();
        }

        public void Restart()
        {
            // Reload the active scene
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}