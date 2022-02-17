using UnityEngine;

namespace LocalMultiplayerGame
{
	[RequireComponent(typeof(Rigidbody2D))]
	public class MovementBehaviour : MonoBehaviour
	{
		[SerializeField] private float speed = 1f;

		private IInputHandler inputHandler;
		private new Rigidbody2D rigidbody;

		private void Awake()
		{
			rigidbody = GetComponent<Rigidbody2D>();
			inputHandler = GetComponent<IInputHandler>();
		}

		private void FixedUpdate()
		{
			Vector3 movement = inputHandler.InputVector * speed;
			rigidbody.velocity = movement;
		}
	}
}
