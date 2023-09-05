
using System.Collections.Generic;
using Source.Scripts.Interfaces;
using UnityEngine;

namespace Source.Scripts
{
    public class Character : IBuffable
    {
        public CharacterStats BaseStats { get; }
        public CharacterStats CurrentStats { get; private set; }
        public readonly List<IBuff> _buffs = new();
        
        
        public Character(CharacterStats baseStats)
        {
            BaseStats = baseStats;
            CurrentStats = BaseStats;
        }

        public void AddBuff(IBuff buff)
        {
            _buffs.Add(buff);
            ApplyBuffs();
        }

        public void RemoveBuff(IBuff buff)
        {
            _buffs.Remove(buff);
            ApplyBuffs();
        }
        
        public void ApplyBuffs()
        {
            CurrentStats = BaseStats;
            foreach (var buff in _buffs)
            {
                CurrentStats = buff.ApplyBuff(CurrentStats);
            }
        }

    }
}