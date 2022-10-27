using UnityEngine;

namespace _source.MVC
{
    public class PlayerController
    {
        private PlayerModel _model;
        private PlayerView _view;

        public PlayerController(PlayerModel model, PlayerView view)
        {
            _model = model;
            _view = view;

            Bind();
        }

        private void Bind()
        {
            _model.OnHealthChange += OnHealthChange;
            _model.OnPlayerDeath += _view.ShowPlayerDead;
            _model.OnPlayerDeath += Expose;
            Damage.OnChange += _model.ChangeHealth;
        }

        private void OnHealthChange(int currHealth) => _view.UpdateHealthView(currHealth);

            private void Expose()
        {
            Damage.OnChange -= _model.ChangeHealth;
            _model.OnHealthChange -= OnHealthChange;
            _model.OnPlayerDeath -= _view.ShowPlayerDead;
            _model.OnPlayerDeath -= Expose;
        }
    }
}
