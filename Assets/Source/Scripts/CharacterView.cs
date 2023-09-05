
using Source.Scripts.Interfaces;
using UnityEngine;

namespace Source.Scripts
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class CharacterView : MonoBehaviour
    {
        private Rigidbody2D _rigidbody;
        private Character _character;
        private IInputListener _inputListener;
        private IMovement _movement;
        private Vector2 _currentDirection;
        private IRotate _rotate;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
        
        public void Update()
        {
            _currentDirection = _inputListener.GetDirection();
        }

        public void FixedUpdate()
        {
            _movement.Move(_currentDirection, _rigidbody);
        }
    }
}