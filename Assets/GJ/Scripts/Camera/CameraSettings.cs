using UnityEngine;

namespace Assets.GJ.Scripts.Camera
{
    [CreateAssetMenu(fileName = "New Camera Settings", menuName = "Camera/CameraSettings", order = 5)]
    public class CameraSettings : ScriptableObject
    {
        [SerializeField] private Vector3 _offset;
        [SerializeField] private float _positionLerpSpeed = 1f;

        public Vector3 Offset => _offset;
        public float PositionLerpSpeed => _positionLerpSpeed;
    }
}
