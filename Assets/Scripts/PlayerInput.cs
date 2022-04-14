using UnityEngine;
using Zenject;

public class PlayerInput : MonoBehaviour
{
    MainComtrolSchema _control;
	CharacterMovement movement;

	private void Awake() {
		_control = new MainComtrolSchema();
        _control.Enable();
	}
	[Inject]
	public void Init(CharacterMovement movement) {
		Debug.Log(movement);	
		this.movement = movement;
	}
	private void Update() {
		movement.Move(_control.Primary.Diagonalmovement.ReadValue<Vector2>().normalized);
	}
}
