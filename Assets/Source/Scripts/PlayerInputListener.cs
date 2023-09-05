using Source.Scripts.Interfaces;
using UnityEngine;

namespace Source.Scripts
{
    public class PlayerInputListener : IInputListener
    {
        public Vector2 GetDirection()
        {
            return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }

        public bool IsAttacking()
        {
            return Input.GetMouseButtonDown(0);
        }
    }
}