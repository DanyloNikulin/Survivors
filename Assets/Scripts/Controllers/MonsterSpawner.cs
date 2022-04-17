using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Controllers
{
	public class MonsterSpawner: MonoBehaviour {
		[SerializeField] MonsterSpawner.Factory _factory;
		[SerializeField] int _amountOfMonsters;
		[SerializeField] GameObject _mosterPrefab;
		[SerializeField] List<GameObject> _monsters;
		[SerializeField] List<Vector2> _mostersPositions;
		[SerializeField] Transform _characterTransform;
		[SerializeField] float _distance;


		[Inject]
		public void Init (MonsterSpawner.Factory factory, Transform characterTransform) {
			_factory = factory;
			_characterTransform = characterTransform;
		}

		private void Awake() {
			Debug.Log(_characterTransform is null);
			Debug.Log(_factory is null);
			_monsters = _factory.Create(_mosterPrefab, _amountOfMonsters);
			_mostersPositions = FigureUtills.CalculateCircle(_amountOfMonsters);
			ScaleFigure();
			TranslateFigure();
			SetMostersOnPositions();
		}
		private void SetMostersOnPositions() {
			for (int i = 0; i < _monsters.Count; i++) {
				_monsters[i].transform.position = _mostersPositions[i];
			}
				
		}
		private void TranslateFigure() {
			for (int i = 0; i < _mostersPositions.Count; i++) {
				_mostersPositions[i] += (Vector2)_characterTransform.position;
			}
		}
		private void ScaleFigure() {
			for (int i = 0; i < _mostersPositions.Count; i++) {
				_mostersPositions[i] *= _distance;
			}
		}
		public class Factory : PlaceholderFactory<GameObject, int, List<GameObject>> {

		}
	}
}
