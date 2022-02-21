using System;
using UnityEngine;

namespace LocalMultiplayerGame
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class SceneTransitionCollider : MonoBehaviour
    {
        [SerializeField] private SceneTransitionBehaviour sceneTransitionBehaviour;

        private void OnTriggerEnter2D(Collider2D col)
        {
            sceneTransitionBehaviour.PlayerCollisionCount++;
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            sceneTransitionBehaviour.PlayerCollisionCount--;
        }
    }
}