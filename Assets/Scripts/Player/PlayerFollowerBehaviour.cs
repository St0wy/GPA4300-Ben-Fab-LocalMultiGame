using UnityEngine;

namespace LocalMultiplayerGame.Player
{
	public class PlayerFollowerBehaviour : MonoBehaviour
	{
		[SerializeField] private Transform playerPos;

		private void Update()
		{
			transform.localPosition = playerPos.localPosition;
		}
	}
}
