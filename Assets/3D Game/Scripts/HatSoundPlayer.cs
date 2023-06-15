using UnityEngine;
using static Unity.VisualScripting.Member;

class HatSoundPlayer : MonoBehaviour
{
    [SerializeField] AudioSource source;

    // ANIM EVENT
    public void PlaySound() 
    {
        source.Play();
        // Debug.Log("Hat Hop");
    }

}
