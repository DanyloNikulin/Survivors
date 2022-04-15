using Models;
using UnityEngine;
using Zenject;

public class UnitFactory: IFactory<GameObject, GameObject> {

	private	readonly DiContainer _container;

	public UnitFactory(DiContainer container) {
		_container = container;
	}
	public GameObject Create(GameObject param) {
		return _container.InstantiatePrefab(param);
	}
}
