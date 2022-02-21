using System;
using UnityEngine;
using UnityEngine.UI;

namespace LocalMultiplayerGame.UI
{
    public class LightHealthUI : MonoBehaviour
    {
        [SerializeField] private LightHealthBehaviour lightHealthBehaviour;

        private Slider slider;

        private void Awake()
        {
            slider = GetComponent<Slider>();

            slider.maxValue = lightHealthBehaviour.MaxLightHealth;
        }

        private void Update()
        {
            slider.value = lightHealthBehaviour.LightHealth;
        }
    }
}