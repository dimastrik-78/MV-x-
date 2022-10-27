using UnityEngine;

namespace _source.Player
{
    public class PlayerModel
    {
        public Rigidbody2D RB;
        public float SpeedX = 2;
        public float SpeedY = 2;

        public PlayerModel(Rigidbody2D rb)
        {
            RB = rb;
        }
    }
}
