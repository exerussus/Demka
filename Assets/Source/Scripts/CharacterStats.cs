using System;

namespace Source.Scripts
{
    [Serializable]
    public struct CharacterStats
    {
        public float Health;
        public float Armor;
        public float Damage;
        public float MoveSpeed;
        public bool IsImmortal;
    }
}