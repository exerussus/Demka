using UnityEngine;

namespace Source.Scripts.Interfaces
{
    public interface IInputListener
    {
        Vector2 GetDirection();
        bool IsAttacking();
    }
}