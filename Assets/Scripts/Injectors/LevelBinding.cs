using UnityEngine;
using Zenject;

namespace Injectors
{
	public class LevelBinding : MonoInstaller	
	{
		[SerializeField] Transform _playerTransform;
		public override void InstallBindings() {
			Container.BindInstance(_playerTransform).WithId("Player").AsSingle();
		}
	}
}
