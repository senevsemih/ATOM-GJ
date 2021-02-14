using Assets.GJ.Scripts.Collectable;
using UnityEngine;

namespace Assets.GJ.Scripts.Environment
{
    public class EnvironmentManager : MonoBehaviour
    {
        [SerializeField] private EnvironmentSettings _environmentSettings;
        [SerializeField] private CollectableSettings _collectableSettings;
        
        private Material _button;
        private bool _hasKey;

        private bool _elevatorActive;

        private void Awake()
        {
            _button = GetComponent<MeshRenderer>().material;
        }

        private void ActiveToElevator()
        {
            if (_collectableSettings.Key > 0)
            {
                _button.color = _environmentSettings.ElevatorButtonColor;
                _hasKey = true;
                _elevatorActive = false;
            }
        }

        private void OnTriggerStay(Collider other)
        {
            ActiveToElevator();
            
            bool hit = other.gameObject.CompareTag("Main Character");
            if (hit && _hasKey)
            {
                if (Input.GetKeyDown(KeyCode.C) && !_elevatorActive)
                {
                    _elevatorActive = true;
                }
            }
        }
    }
}
