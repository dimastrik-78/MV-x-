using System;
using UnityEngine;

namespace _source
{
    public class Damage : MonoBehaviour
    {
        public static Action<int> OnChange;
        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.layer == 3)
            {
                OnChange?.Invoke(-10);
            }
        }
    }
}
