using UnityEngine;

namespace Assets.GJ.Scripts.Enemy
{
    [CreateAssetMenu(fileName = "New Enemy Settings", menuName = "Enemy/Enemy Settings", order = 1)]
    public class EnemySettings : ScriptableObject
    {
        [SerializeField] private float _enemyMovePerUnit = 5f;
        
        public float EnemyMovePerUnit => _enemyMovePerUnit;
    }
}
