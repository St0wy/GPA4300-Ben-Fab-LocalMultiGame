using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace LocalMultiplayerGame
{
	public class CameraSetter : MonoBehaviour
	{
		[SerializeField] private new Camera camera;
		private PlayerInput playerInput;

		private void Awake()
		{
			playerInput = GetComponent<PlayerInput>();
		}

		private void Start()
		{
			playerInput.camera = camera;
		}
	}
}
