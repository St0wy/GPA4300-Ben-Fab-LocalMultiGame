using UnityEngine;

namespace LocalMultiplayerGame.Player
{
	public interface IInputHandler
	{
		public delegate void InputEventHandler();

		public Vector2 InputVector { get; }

		event InputEventHandler Interact;
		event InputEventHandler Pause;
	}
}
