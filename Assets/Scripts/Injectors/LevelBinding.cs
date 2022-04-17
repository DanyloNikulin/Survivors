using Controllers;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Injectors
{
	public class LevelBinding : MonoInstaller	
	{
		[SerializeField] Transform _playerTransform;
		public override void InstallBindings() {
			Container.BindInstance(_playerTransform).WithId("Player").AsSingle();
			
			BindFactories();
		}

		private void BindFactories()
		{ 
			Container.BindFactory<GameObject, int, List<GameObject>, MonsterSpawner.Factory>().FromFactory<UnitFactory>();
		}

	}
}
