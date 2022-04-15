
using UnityEngine;

namespace Models {
    [CreateAssetMenu(menuName = "UnitsData/Character", fileName = "Character")]
    public class Character: Unit {
        [field: SerializeField] public string CharacterDescriptor { get; protected set; }
    }
}
