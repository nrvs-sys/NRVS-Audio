using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

[RequireComponent(typeof(StudioEventEmitter))]
public class FMODParameterUtility : MonoBehaviour
{
	[Header("Settings")]
	public string parameterName;


	private StudioEventEmitter emitter;


	private void Awake()
	{
		emitter = GetComponent<StudioEventEmitter>();
	}


	public void Set(float value) => emitter.SetParameter(parameterName, value);
	public void Set(int value) => emitter.SetParameter(parameterName, value);
}