﻿using UnityEngine;

namespace LocalMultiplayerGame
{
	public class MovementBehaviour : MonoBehaviour
	{
		[SerializeField] private float speed = 1f;

		private IInputHandler inputHandler;

		private void Awake()
		{
			inputHandler = GetComponent<IInputHandler>();
			inputHandler.Pause += Pause;
		}

		private void FixedUpdate()
		{
			Vector3 movement = inputHandler.InputVector * speed;
			transform.position += movement;
		}

		private void Pause()
		{
			Debug.Log("C'est la pause");
		}
	}
}
