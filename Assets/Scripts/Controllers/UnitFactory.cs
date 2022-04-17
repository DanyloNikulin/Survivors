using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Controllers
{
	public class UnitFactory: IFactory<GameObject, int, List<GameObject>>{

		private	readonly DiContainer _container;

		public UnitFactory(DiContainer container) {
			_container = container;
		}
		public List<GameObject> Create(GameObject preFab, int amount) {
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < amount; i++) {
				list.Add(_container.InstantiatePrefab(preFab));
			}
			return list;
		}
	}
}
