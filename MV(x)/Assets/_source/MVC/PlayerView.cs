using System;
using UnityEngine;
using UnityEngine.UI;

namespace _source.MVC
{
    public class PlayerView : MonoBehaviour
    {
        [HideInInspector] public Text HealthText;

        public void UpdateHealthView(int currHealthView)
        {
            HealthText.text = currHealthView.ToString();

            if (currHealthView > 50)
                gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
            else
                gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0);
        }

        public void ShowPlayerDead()
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
        }
    }
}
