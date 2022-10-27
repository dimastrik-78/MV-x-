using UnityEngine;

namespace _source.Player
{
    public class PlayerInput : MonoBehaviour
    {
        private PlayerMoveController _moveController;

        public PlayerModel Model;
        public void Update()
        {
            if (Input.GetAxis("Horizontal") != 0
                || Input.GetAxis("Vertical") != 0)
            {
                _moveController = new PlayerMoveController();
                _moveController.Move(Model.RB, Model.SpeedX, Model.SpeedY);
            }
        }
    }
}
