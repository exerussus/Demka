
using Source.Scripts.Interfaces;

namespace Source.Scripts
{
    public class TemporaryBuff : IBuff
    {
        private readonly IBuffable _owner;
        private readonly IBuff _coreBuff;
        private readonly float _lifeTime;
        private readonly Timer.Timer _timer;

        public TemporaryBuff(IBuffable owner, IBuff buff, float lifeTime)
        {
            _owner = owner;
            _coreBuff = buff;
            _lifeTime = lifeTime;
            _timer = new Timer.Timer(Timer.TimerType.UpdateTickUnscaled, lifeTime);
        }
        
        public CharacterStats ApplyBuff(CharacterStats baseStats)
        {
            var newStats = _coreBuff.ApplyBuff(baseStats);
            _timer.Start(_lifeTime);
            _timer.OnTimerFinishedEvent += () =>
            {
                _owner.RemoveBuff(_coreBuff);
            };
            return newStats;
        }
    }
}