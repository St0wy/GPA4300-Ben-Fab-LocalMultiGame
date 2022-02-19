﻿using System;
using UnityEngine;

namespace LocalMultiplayerGame
{
	public class CameraFollow : MonoBehaviour
	{
		[SerializeField] private Transform playerPos;

		private void Start()
		{
			Vector3 position = playerPos.position;
			position.z = -1f;
			transform.position = position;
		}
	}
}