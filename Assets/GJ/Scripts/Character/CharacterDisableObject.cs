using System.Collections;
using System.Collections.Generic;
using Assets.GJ.Scripts.Game_Manager;
using UnityEngine;

namespace Assets.GJ.Scripts.Character
{
    public class CharacterDisableObject : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _walls = new List<GameObject>();
        [SerializeField] private CheckPointSettings _checkPointSettings;
        
        private void OnCollisionEnter(Collision other)
        {
            if (!other.gameObject.CompareTag("Invisible Wall")) return;
            if (_walls.Contains(other.gameObject)) return;
            _walls.Add(other.gameObject);

            foreach (var wall in _walls)
            {
                wall.GetComponent<BoxCollider>().isTrigger = true;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Trap"))
            {
                transform.position = _checkPointSettings.Level1CheckPoint;
            }
        }
        
        private void OnTriggerExit(Collider other)
        {
            StartCoroutine(WaitForExit(other.gameObject));
        }

        private IEnumerator WaitForExit(GameObject other)
        {
            yield return new WaitForSeconds(1f);
            foreach (var wall in _walls)
            {
                wall.GetComponent<BoxCollider>().isTrigger = false;
            }

            _walls.Remove(other);
        }
    }
}
