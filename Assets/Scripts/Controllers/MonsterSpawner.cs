using UnityEngine;
using Zenject;

public class MonsterSpawner : MonoBehaviour
{
	[SerializeField] MonsterSpawner.Factory _factory;
	[SerializeField] GameObject _mosterPrefab;
	[Inject]
	public void Init (MonsterSpawner.Factory factory) {
		_factory = factory;
	}

	private void Start() {
		_mosterPrefab = _factory.Create(_mosterPrefab);
		_mosterPrefab.transform.position = Vector3.one;
	}
	public class Factory:PlaceholderFactory<GameObject, GameObject> {

	}
}
