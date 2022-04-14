using UnityEngine;
using Zenject; 



[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMovement: MonoBehaviour
{
	Rigidbody2D _body;
	[SerializeField] float _speed;
	[Inject]
	public void Init(Rigidbody2D body) {
		_body = body;
	}
	public void Move(Vector2 direction) {
		_body.velocity = direction * _speed;
	}
}
