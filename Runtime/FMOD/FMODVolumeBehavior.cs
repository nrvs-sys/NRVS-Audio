using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD.Studio;

[CreateAssetMenu(fileName = "Volume Behavior_ New", menuName = "Behaviors/Audio/FMOD/Volume")]
public class FMODVolumeBehavior : ScriptableObject
{
	public string busName = "";

	public void SetVolume(float volume)
	{
		Bus bus = FMODUnity.RuntimeManager.GetBus("bus:/" + busName);

		bus.setVolume(volume);
	}
}