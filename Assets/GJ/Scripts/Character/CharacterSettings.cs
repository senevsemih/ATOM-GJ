using UnityEngine;

namespace Assets.GJ.Scripts.Character
{
    [CreateAssetMenu(fileName = "New Character Settings", menuName = "Character/CharacterSettings", order = 3)]
    public class CharacterSettings : ScriptableObject
    {
        [Header("SPEED")]
        [Range(0f, 10f)]
        [SerializeField] private float _rollSpeed;
        
        [Header("DIRECTION")]
        [SerializeField] private Vector3 _leftDirection;
        [SerializeField] private Vector3 _rightDirection;

        [Header("SCALE")] 
        [SerializeField] private Vector3 _scale;


        public float RollSpeed => _rollSpeed;
        public Vector3 LeftDirection => _leftDirection;
        public Vector3 RightDirection => _rightDirection;
        public Vector3 Scale => _scale;
    }
}
