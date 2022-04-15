
using UnityEngine;
using Zenject;

public class SpawnerBinder : MonoInstaller {

	public override void InstallBindings() {
		Container.BindFactory<GameObject, GameObject, MonsterSpawner.Factory>().FromFactory<UnitFactory>();
	}

}
