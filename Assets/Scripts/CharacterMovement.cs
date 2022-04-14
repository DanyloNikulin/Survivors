using UnityEngine;
using Zenject;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMovement: MonoBehaviour
{
	[SerializeField] private float _speed;
	
	private Rigidbody2D _body;
	
	[Inject]
	public void Init(Rigidbody2D body) {
		_body = body;
	}
	
	public void Move(Vector2 direction) {
		_body.velocity = direction * _speed;
	}
}
