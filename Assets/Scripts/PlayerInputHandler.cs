using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

namespace LocalMultiplayerGame
{
	public class PlayerInputHandler : MonoBehaviour, IInputHandler
	{
		public event IInputHandler.InputEventHandler Interact;
		public event IInputHandler.InputEventHandler Pause;

		public Vector2 InputVector { get; private set; }

		[UsedImplicitly]
		private void OnMove(InputValue value)
		{
			InputVector = value.Get<Vector2>();
		}

		[UsedImplicitly]
		private void OnPause()
		{
			Pause?.Invoke();
		}

		[UsedImplicitly]
		private void OnInteract()
		{
			Interact?.Invoke();
		}
	}
}
