using UnityEngine;
namespace Models {
	public class Unit: ScriptableObject {
		[field: SerializeField] public int HeathPoint { get; protected set; }
		[field: SerializeField] public float Speed { get; protected set; }
		[field: SerializeField] public string UnitName { get; protected set; }
		[field: SerializeField] public GameObject UnitDoll { get; protected set; }
	}
}
