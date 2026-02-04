using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class FMODPauseUtility : MonoBehaviour
{
	private readonly List<StudioEventEmitter> _emittersToResume = new();

    public void SetAudible(bool isAudible)
    {
        // manage child FMOD emitters
        var emitters = GetComponentsInChildren<StudioEventEmitter>(includeInactive: true);
        if (!isAudible)
        {
            _emittersToResume.Clear();

            for (int i = 0; i < emitters.Length; i++)
            {
                var e = emitters[i];
                if (e == null) continue;

                bool isPlaying = false;
                try { isPlaying = e.IsPlaying(); } catch { /* older FMOD versions */ }

                if (isPlaying)
                {
                    e.Stop();
                    _emittersToResume.Add(e);
                }
            }
        }
        else
        {
            for (int i = 0; i < _emittersToResume.Count; i++)
            {
                var e = _emittersToResume[i];
                if (e) e.Play();
            }
            _emittersToResume.Clear();
        }
    }
}