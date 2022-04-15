using UnityEngine;
using Zenject;

namespace Controllers
{
	public class UnitFactory: IFactory<GameObject, GameObject> {

		private	readonly DiContainer _container;

		public UnitFactory(DiContainer container) {
			_container = container;
		}
		public GameObject Create(GameObject param) {
			return _container.InstantiatePrefab(param);
		}
	}
}
