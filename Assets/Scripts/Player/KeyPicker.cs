using UnityEngine;
using UnityEngine.Tilemaps;

namespace LocalMultiplayerGame.Player
{
	public class KeyPicker : MonoBehaviour
	{
		public const string KeyTag = "Key";
		
		[SerializeField] private Tile tileToSet;
		[SerializeField] private Tilemap tilemap;
		[SerializeField] private Vector3Int[] tilesToChange;

		public bool HasKey { get; private set; }

		private void OnTriggerEnter2D(Collider2D col)
		{
			// Check if we collided with a key
			if (!col.gameObject.CompareTag(KeyTag))
				return;

			Destroy(col.gameObject);
			HasKey = true;

			foreach (Vector3Int tilePos in tilesToChange)
			{
				tilemap.SetTile(tilePos, tileToSet);
			}
		}
	}
}
