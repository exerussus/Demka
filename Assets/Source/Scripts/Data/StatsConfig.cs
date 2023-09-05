using UnityEngine;

namespace Source.Scripts.Data
{
    [CreateAssetMenu(menuName = "Config/Stats", fileName = "StatsConfig")]
    
    public class StatsConfig : ScriptableObject
    {
        [SerializeField] private CharacterStats startedStats;
        public CharacterStats StartedStats => startedStats;
    }
}