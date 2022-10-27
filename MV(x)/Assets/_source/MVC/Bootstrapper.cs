using System;
using UnityEngine;
using UnityEngine.UI;

namespace _source.MVC
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private Text healthText;
        
        private PlayerModel _model;
        private PlayerView _view;
        private PlayerController _controller;

        private void Awake()
        {
            _model = new PlayerModel();
            _view = Instantiate(playerPrefab).GetComponent<PlayerView>();
            _controller = new PlayerController(_model, _view);
            
            _view.HealthText = healthText;
            
            Damage.OnChange?.Invoke(0);
        }
    }
}
