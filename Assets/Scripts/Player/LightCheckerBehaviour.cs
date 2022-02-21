using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

namespace LocalMultiplayerGame.Player
{
    public class LightCheckerBehaviour : MonoBehaviour
    {
        [SerializeField] private LightHealthBehaviour lightHealthBehaviour;
        [SerializeField] private Light2D otherPlayerLight;

        private void Update()
        {
            // Get the distance between the player and the light
            float distance = Vector2.Distance(transform.position, otherPlayerLight.transform.position);

            // Check if we are outside the light and send it to the LightHealthBehaviour
            lightHealthBehaviour.IsInShadow = distance > otherPlayerLight.pointLightOuterRadius;
        }
    }
}