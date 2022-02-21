using LocalMultiplayerGame.UI;
using UnityEngine;

namespace LocalMultiplayerGame
{
    public class LightHealthBehaviour : MonoBehaviour
    {
        [SerializeField] private GameOverBehaviour gameOverBehaviour;
        [SerializeField] private float maxLightHealth = 1f;

        [Tooltip("The amount of health that is lost per seconds.")] [SerializeField]
        private float healthTick = 0.5f;

        [field: SerializeField] public float LightHealth { get; private set; } = 1f;

        public float MaxLightHealth => maxLightHealth;

        public bool IsInShadow { get; set; }

        private void Awake()
        {
            LightHealth = maxLightHealth;
        }

        private void Update()
        {
            if (IsInShadow)
            {
                LightHealth -= healthTick * Time.deltaTime;
            }
            else
            {
                LightHealth = MaxLightHealth;
            }

            if (!(LightHealth <= 0)) return;

            if (gameOverBehaviour != null)
                gameOverBehaviour.TriggerGameOver();
        }
    }
}