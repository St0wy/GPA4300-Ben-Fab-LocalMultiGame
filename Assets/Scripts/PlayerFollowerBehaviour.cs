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

		private void OnDrawGizmos()
		{
			// Gizmos.DrawSphere(transform.position, 1f);
		}
	}
}
