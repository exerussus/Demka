using System;
using UnityEngine;

namespace Source.Scripts.Timer
{
    public class TimeInvoker : MonoBehaviour
    {
        public event Action<float> OnUpdateTimeTickedEvent;
        public event Action<float> OnUpdateTimeUnscaledTickedEvent;
        public event Action OnOneSecondTickedEvent;
        public event Action OnOneSecondUnscaledTickedEvent;

        private static TimeInvoker _instance;
        public static TimeInvoker Instance
        {
            get
            {
                if (_instance != null) return _instance;
                var go = new GameObject("[TIME INVOKER]");
                _instance = go.AddComponent<TimeInvoker>();
                DontDestroyOnLoad(go);
                return _instance;
            }
        }

        private float _oneSecTimer;
        private float _oneSecUnscaledTimer;

        private void Update()
        {
            var deltaTime = Time.deltaTime;
            OnUpdateTimeTickedEvent?.Invoke(deltaTime);

            _oneSecTimer += deltaTime;
            if (_oneSecTimer >= 1f)
            {
                _oneSecTimer -= 1f;
                OnOneSecondTickedEvent?.Invoke();
            }

            var unscaledDeltaTime = Time.unscaledDeltaTime;
            OnUpdateTimeUnscaledTickedEvent?.Invoke(unscaledDeltaTime);
            
            _oneSecUnscaledTimer += unscaledDeltaTime;
            if (_oneSecUnscaledTimer >= 1f)
            {
                _oneSecUnscaledTimer -= 1f;
                OnOneSecondUnscaledTickedEvent?.Invoke();
            }
        }
    }
}