using System;
using UnityEngine;

namespace _source.MVC
{
    public class PlayerModel
    {
        private int _health;
        private int _maxHeal = 100;
        
        public Action<int> OnHealthChange;
        public Action OnPlayerDeath;
        public Action OnExpose;

        public PlayerModel()
        {
            _health = _maxHeal;
        }

        public void ChangeHealth(int deltaHealth)
        {
            _health += deltaHealth;
            OnHealthChange?.Invoke(_health);
            
            if (_health <= 0)
            {
                OnPlayerDeath?.Invoke();
            }
        }
    }
}
