using UnityEngine;

namespace LocalMultiplayerGame
{
	public class PlayerInputReciever : MonoBehaviour, IInputHandler
	{
		public event IInputHandler.InputEventHandler Interact;
		public event IInputHandler.InputEventHandler Pause;

		[SerializeField] private int playerIndex;

		public Vector2 InputVector { get; set; }

		public int PlayerIndex => playerIndex;

		public void TriggerPause()
		{
			Pause?.Invoke();
		}
		
		public void TriggerInteract()
		{
			Interact?.Invoke();
		}
	}
}
