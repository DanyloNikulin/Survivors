
using UnityEngine;

namespace Models {
    [CreateAssetMenu(menuName = "UnitsData/Charater", fileName = "Charater")]
    public class Charater: Unit {
        [field: SerializeField] public string CharaterDescriptor { get; protected set; }
    }
}
