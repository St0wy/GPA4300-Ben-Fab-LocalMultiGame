using UnityEngine;
using UnityEngine.SceneManagement;

namespace LocalMultiplayerGame.UI
{
    public class WinMenuUI : MonoBehaviour
    {
        public void LoadMainMenu()
        {
            SceneManager.LoadScene(0);
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}