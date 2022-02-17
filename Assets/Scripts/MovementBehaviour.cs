using UnityEngine;

namespace LocalMultiplayerGame
{
	public class MovementBehaviour : MonoBehaviour
	{
		public const float SpeedModifier = 0.1f;

		[SerializeField] private float speed = 1f;

		private IInputHandler inputHandler;

		private void Awake()
		{
			inputHandler = GetComponent<IInputHandler>();
			inputHandler.Pause += Pause;
		}

		private void FixedUpdate()
		{
			Vector3 movement = inputHandler.InputVector * (speed * SpeedModifier);
			transform.position += movement;
		}

		private void Pause()
		{
			Debug.Log("C'est la pause");
		}
	}
}
