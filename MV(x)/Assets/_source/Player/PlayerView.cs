using UnityEngine;

namespace _source.Player
{
    public class PlayerView : MonoBehaviour
    {
        public PlayerInput Input;
        
        private Rigidbody2D _rb;

        private PlayerModel _model;
        void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();

            _model = new PlayerModel(_rb);
            Input.Model = _model;
        }
    }
}
