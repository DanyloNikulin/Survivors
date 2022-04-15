using UnityEngine;
using Zenject;

public class MonsterAi : MonoBehaviour
{

    Transform _playerTransfor;
    [SerializeField] float _speed;
    [SerializeField] Rigidbody2D _body;


    [Inject]
    public void Init([Inject(Id = "Player")] Transform playerTransfor, Rigidbody2D _body) {
        this._playerTransfor = playerTransfor;
        this._body = _body;
    }

    void Update()
    {
        Move();
    }

    void Move() {
        _body.velocity = ((Vector2)_playerTransfor.position - _body.position).normalized * _speed;   
	}
}
