using UnityEngine;

namespace Assets.GJ.Scripts.Environment
{
    [CreateAssetMenu(fileName = "New Environment Settings", menuName = "Environment/Environment Settings", order = 7)]
    public class EnvironmentSettings : ScriptableObject
    {
        [Header("ELEVATOR BUTTON")] 
        [SerializeField] private Color _elevatorButtonColor;
        public Color ElevatorButtonColor => _elevatorButtonColor;
    }
}
