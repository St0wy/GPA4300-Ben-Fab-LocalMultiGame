using System.Linq;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

namespace LocalMultiplayerGame
{
	/// <summary>
	/// Class that will send input reads from the device to the player reciever that has the same ID.
	/// Used to have multiple players without having them spawn on the Scene.
	/// This script should be the one instanciated by the PlayerInputManager.
	/// </summary>
	/// <remarks>Taken from : https://www.youtube.com/watch?v=2YhGK-PXz7g</remarks>
	[RequireComponent(typeof(PlayerInput))]
	public class PlayerInputSender : MonoBehaviour
	{
		private PlayerInput playerInput;
		private PlayerInputReciever playerInputReciever;

		private void Awake()
		{
			// Get the PlayerInput on this gameobject
			playerInput = GetComponent<PlayerInput>();

			// Find all the PlayerInputRecievers on the scene (they should be attached to the players)
			PlayerInputReciever[] recievers = FindObjectsOfType<PlayerInputReciever>();

			// Get the reciever that has the same player ID as the PlayerInput 
			playerInputReciever = recievers.FirstOrDefault(i => i.PlayerIndex == playerInput.playerIndex);

			if (recievers.Length < 1)
			{
				this.LogError($"Not enough players in the scene. (found {recievers.Length})");
			}
		}

		[UsedImplicitly]
		private void OnMove(InputValue value)
		{
			playerInputReciever.InputVector = value.Get<Vector2>();
		}

		[UsedImplicitly]
		private void OnPause()
		{
			playerInputReciever.TriggerPause();
		}

		[UsedImplicitly]
		private void OnInteract()
		{
			playerInputReciever.TriggerInteract();
		}
	}
}
