using UnityEngine;

namespace Assets.GJ.Scripts.Collectable
{
    [CreateAssetMenu(fileName = "New Collectable Settings", menuName = "Collectable/Collectable Settings", order = 6)]
    public class CollectableSettings : ScriptableObject
    {
        [SerializeField] private int _key = 0;

        public int Key
        {
            get => _key;
            set => _key = value;
        }
    }
}
