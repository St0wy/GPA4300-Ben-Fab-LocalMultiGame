using UnityEngine;

namespace LocalMultiplayerGame.Player
{
	[RequireComponent(typeof(Rigidbody2D))]
	public class MovementBehaviour : MonoBehaviour
	{
		[SerializeField] private float speed = 1f;

		private IInputHandler inputHandler;
		private Rigidbody2D rb;

		private void Awake()
		{
			rb = GetComponent<Rigidbody2D>();
			inputHandler = GetComponent<IInputHandler>();
		}

		private void FixedUpdate()
		{
			Vector3 movement = inputHandler.InputVector * speed;
			rb.velocity = movement;
		}
	}
}
