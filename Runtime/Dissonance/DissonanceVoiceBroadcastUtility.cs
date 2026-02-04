using UnityEngine;
using Dissonance;

[RequireComponent(typeof(VoiceBroadcastTrigger))]
public class DissonanceVoiceBroadcastUtility : MonoBehaviour
{
    private float _broadcastVolume = 1f;
    public float broadcastVolume
	{
        get => _broadcastVolume;
        set
		{
            if (voiceBroadcastTrigger == null)
                return;

            _broadcastVolume = value;

            voiceBroadcastTrigger.ActivationFader.Volume = value;
        }
	}


    VoiceBroadcastTrigger voiceBroadcastTrigger;

    void Awake() => voiceBroadcastTrigger = GetComponent<VoiceBroadcastTrigger>();
}