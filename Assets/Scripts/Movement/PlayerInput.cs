using Input;
using UnityEngine;
using Zenject;

namespace Movement
{
	public class PlayerInput : MonoBehaviour
	{
		private MainComtrolSchema _control;
		private CharacterMovement _movement;

		private void Awake() {
			_control = new MainComtrolSchema();
			_control.Enable();
		}
	
		[Inject]
		public void Init(CharacterMovement movement) {	
			_movement = movement;
		}
	
		private void Update() {
			_movement.Move(_control.Primary.Diagonalmovement.ReadValue<Vector2>().normalized);
		}
	}
}
