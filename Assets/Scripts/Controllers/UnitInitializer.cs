using UnityEngine;
using Models;
using Zenject;

namespace Controllers
{
	public class UnitInitializer: MonoBehaviour
	{
		[SerializeField] Unit unit;
		
		[Inject]
		public void Init(string unitName) {



		}
    
	}
}
