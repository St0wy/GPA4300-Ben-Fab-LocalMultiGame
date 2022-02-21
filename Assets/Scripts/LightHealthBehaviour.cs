using System;
using System.ComponentModel;
using UnityEngine;

namespace LocalMultiplayerGame
{
    public class LightHealthBehaviour : MonoBehaviour
    {
        [SerializeField] private float maxLightHealth = 1f;

        [field: SerializeField] public float LightHealth { get; private set; } = 1f;

        public float MaxLightHealth => maxLightHealth;

        private void Awake()
        {
            LightHealth = maxLightHealth;
        }
    }
}