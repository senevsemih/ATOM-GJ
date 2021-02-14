using UnityEngine;
using UnityEngine.UIElements;

namespace Assets.GJ.Scripts.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        [SerializeField] private Transform _character;
        [SerializeField] private Transform _camera;
        
        private void Update()
        {
            CameraPositionFollow();
        }
        
        private void CameraPositionFollow()
        {
            _camera.position = Vector3.Lerp(_camera.position,
                _character.position + _cameraSettings.Offset, 
                Time.deltaTime * _cameraSettings.PositionLerpSpeed);
        }
    }
}
