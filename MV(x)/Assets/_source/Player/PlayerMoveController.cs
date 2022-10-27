using UnityEngine;

namespace _source.Player
{
    public class PlayerMoveController
    {
        public void Move(Rigidbody2D rb, float speedX, float speedY)
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speedX, Input.GetAxis("Vertical") * speedY);
        }
    }
}
