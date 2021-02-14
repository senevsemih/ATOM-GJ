using UnityEngine;

namespace Assets.GJ.Scripts.Patrol
{
    public class PatrolManager : MonoBehaviour
    {
        [SerializeField] private PatrolSettings _patrolSettings;
        private Vector3 direction;

        public Vector3 Direction => direction;

        private void Start()
        {
            direction = _patrolSettings.Direciton;
        }
    }
}
