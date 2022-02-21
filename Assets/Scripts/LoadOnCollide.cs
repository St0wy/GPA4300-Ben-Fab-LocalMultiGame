using UnityEngine;
using UnityEngine.SceneManagement;

namespace LocalMultiplayerGame
{
	public class LoadOnCollide : MonoBehaviour
	{
		private void OnCollisionEnter2D(Collision2D col)
		{
			SceneManager.LoadScene(2);
		}
	}
}
