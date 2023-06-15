using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SoundGroup : ScriptableObject
{
    [SerializeField] List<AudioClip> clips;

    int lastSoundIndex = -1;

    public AudioClip GetRandomClip() 
    {
        int randomIndex;
        do
        {
            randomIndex = Random.Range(0, clips.Count);
        }
        while (randomIndex == lastSoundIndex && clips.Count > 1);

        lastSoundIndex = randomIndex;
        return clips[randomIndex];
    }
}
