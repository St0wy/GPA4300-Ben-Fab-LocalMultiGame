using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LocalMultiplayerGame.UI
{
    public class MainMenuUI : MonoBehaviour
    {
        private void Start()
        {
            Cursor.visible = false;
        }

        public void LoadGame()
        {
            SceneManager.LoadScene(1);
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}