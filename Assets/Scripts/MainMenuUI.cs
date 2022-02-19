using UnityEngine;
using UnityEngine.SceneManagement;

namespace LocalMultiplayerGame
{
	public class MainMenuUI : MonoBehaviour
	{
		public void LoadGame()
		{
			SceneManager.LoadScene(1);
		}
	}
}
