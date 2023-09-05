
using UnityEngine;

namespace Source.Scripts.Interfaces
{
    public interface IMovement
    {
        void Move(Vector2 direction, Rigidbody2D rigidbody);
    }
}
