using UnityEngine;

namespace LocalMultiplayerGame
{
	public class MovementBehaviour : MonoBehaviour
	{
		[field: SerializeField]
		public float Speed { get; } = 1f;

		private IInputHandler inputHandler;

		private void Awake()
		{
			inputHandler = GetComponent<IInputHandler>();
			inputHandler.Pause += Pause;
		}

		private void FixedUpdate()
		{
			Vector3 movement = inputHandler.InputVector * (Speed * Time.deltaTime);
			transform.position += movement;
		}

		private void Pause()
		{
			Debug.Log("C'est la pause");
		}
	}
}
