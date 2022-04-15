using UnityEngine;

namespace Models {
	[CreateAssetMenu(menuName = "UnitsData/Monster", fileName = "Monster")]
	public class Monster: Unit {
		[field: SerializeField] public float Damage { get; protected set; }
		[field: SerializeField] public float AttackCooldown { get; protected set; }
	}
}
