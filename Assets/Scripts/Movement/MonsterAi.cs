using UnityEngine;
using Zenject;

namespace Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class MonsterAi : MonoBehaviour
    {

        Transform _playerTransform;
        [SerializeField] float _speed;
        [SerializeField] Rigidbody2D _body;


        [Inject]
        public void Init([Inject(Id = "Player")] Transform playerTransform, Rigidbody2D body) {
            _playerTransform = playerTransform;
            _body = body;
        }

        void Update()
        {
            Move();
        }

        void Move() {
            _body.velocity = ((Vector2)_playerTransform.position - _body.position).normalized * _speed;   
        }
    }
}
