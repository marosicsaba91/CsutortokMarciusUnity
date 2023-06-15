using UnityEngine;
using static Unity.VisualScripting.Member;

public class TriggerSoundPlayer : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] SoundGroup group;


    void OnTriggerEnter2D(Collider2D collision)
    {
        AudioClip clip = group.GetRandomClip();

        source.clip = clip;
        source.Play();
    }
}
