using UnityEngine;
using UnityEngine.UI;

namespace Assets.GJ.Scripts.Collectable
{
    public class CollectableManager : MonoBehaviour
    {
        [SerializeField] private CollectableSettings _collectableSettings;
        [SerializeField] private Image _keyImage;

        private void OnTriggerEnter(Collider other)
        {
            bool hit = other.gameObject.CompareTag("Main Character");
            if (!hit) return;
            _collectableSettings.Key += 1;
            _keyImage.enabled = true;
            
            Destroy(gameObject, .1f);
        }
    }
}
