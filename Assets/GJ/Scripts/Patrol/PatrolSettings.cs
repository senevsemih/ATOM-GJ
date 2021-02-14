using UnityEngine;

namespace Assets.GJ.Scripts.Patrol
{
    [CreateAssetMenu(fileName = "New Patrol Settings", menuName = "Patrol/Patrol Settings", order = 2)]
    public class PatrolSettings : ScriptableObject
    {
        [SerializeField] private Vector3 _direciton;

        public Vector3 Direciton => _direciton;
    }
}
