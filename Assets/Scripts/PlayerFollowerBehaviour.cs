using System;
using UnityEngine;

namespace LocalMultiplayerGame
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
