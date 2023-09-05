using UnityEngine;

namespace Source.Scripts.Interfaces
{
    public interface IRotate
    {
        void Rotate(Transform ownerTransform, Vector2 direction);
    }
}