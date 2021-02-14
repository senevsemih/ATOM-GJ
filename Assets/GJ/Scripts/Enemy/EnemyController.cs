using Assets.GJ.Scripts.Character;
using Assets.GJ.Scripts.Patrol;
using UnityEngine;

namespace Assets.GJ.Scripts.Enemy
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private EnemySettings _enemySettings;

        private Vector3 _nextDirection;
        private Rigidbody _rb;
        
        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            Move(Vector3.right);
        }

        private void Update()
        {
            Move(_nextDirection);
        }
        
        private void Move(Vector3 direction)
        {
            _rb.AddForce(direction * _enemySettings.EnemyMovePerUnit * Time.deltaTime);
        }

        private void OnCollisionEnter(Collision collision)
        {
            var hit = collision.gameObject;
            if (hit.CompareTag("Invisible Wall"))
            {
                _nextDirection = hit.GetComponent<PatrolManager>().Direction;
            }
            if (hit.CompareTag("Broken Wall"))
            {
                Destroy(hit.gameObject, .3f);
            }

            var characterManager = hit.gameObject.GetComponent<CharacterManager>();
            if (!hit.CompareTag("Main Character")) return;
            if (characterManager.States == CharacterStates.Box)
            {
                Debug.Log("DEAD");
            }
            else
            {
                return;
            }
        }
    }
}
