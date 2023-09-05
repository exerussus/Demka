using UnityEngine;

namespace Source.Scripts.Data
{
    [CreateAssetMenu(menuName = "Config/MainConfig", fileName = "MainConfig")]
    public class MainConfig : ScriptableObject
    {
        [SerializeField] private StatsConfig statsConfig;
        public StatsConfig StatsConfig => statsConfig;
    }
}