using System.Linq;
using JetBrains.Annotations;
using LocalMultiplayerGame.Utils;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace LocalMultiplayerGame.Player
{
    /// <summary>
    /// Class that will send input reads from the device to the <see cref="PlayerInputReceiver"/> that has the same ID.
    /// Used to have multiple players without having them spawn on the Scene.
    /// This script should be the one instantiated by the PlayerInputManager.
    /// </summary>
    /// <remarks>Taken from : https://www.youtube.com/watch?v=2YhGK-PXz7g</remarks>
    [RequireComponent(typeof(PlayerInput))]
    public class PlayerInputSender : MonoBehaviour
    {
        private PlayerInput playerInput;
        private PlayerInputReceiver playerInputReceiver;

        public Transform PlayerPos => playerInputReceiver.transform;

        private void Awake()
        {
            // Get the PlayerInput on this game object
            playerInput = GetComponent<PlayerInput>();

            // Set this object to not be destroyed when loading an other scene
            DontDestroyOnLoad(this);

            // Make is so we get the new receivers when a scene is loaded
            SceneManager.sceneLoaded += (arg0, mode) => LoadInputReceiver();

            LoadInputReceiver();
        }

        private void LoadInputReceiver()
        {
            // Find all the PlayerInputReceivers on the scene (they should be attached to the players)
            var receivers = FindObjectsOfType<PlayerInputReceiver>();

            // Get the receiver that has the same player ID as the PlayerInput 
            playerInputReceiver = receivers.FirstOrDefault(i => i.PlayerIndex == playerInput.playerIndex);

            // Check the number of recievers
            if (receivers.Length < 1)
            {
                this.LogError($"Not enough players in the scene. (found {receivers.Length})");
            }
        }

        [UsedImplicitly]
        private void OnMove(InputValue value)
        {
            playerInputReceiver.InputVector = value.Get<Vector2>();
        }

        [UsedImplicitly]
        private void OnPause()
        {
            playerInputReceiver.TriggerPause();
        }

        [UsedImplicitly]
        private void OnInteract()
        {
            playerInputReceiver.TriggerInteract();
        }
    }
}