using UnityEngine;

namespace Assets.GJ.Scripts.Game_Manager
{
    [CreateAssetMenu(fileName = "New CheckPoint Settings", menuName = "CheckPoint/CheckPoint Settings", order = 8)]
    public class CheckPointSettings : ScriptableObject
    {
        [SerializeField] private Vector3 _level1CheckPoint;
        
        public Vector3 Level1CheckPoint => _level1CheckPoint;
    }
}
