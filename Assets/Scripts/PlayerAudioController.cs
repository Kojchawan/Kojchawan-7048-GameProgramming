using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private SoAudioClips walkAudioClips;
    [SerializeField] private SoAudioClips jumpAudioClips;
    [SerializeField] private SoAudioClips deathAudioClips;
    [SerializeField] private SoAudioClips winAudioClips;

    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpAudioClips.GetAudioClips());
    }
    
    public void PlayWalkSound()
    {
        audioSource.PlayOneShot(walkAudioClips.GetAudioClips(), 0.5f);
    }
    
    public void PlayDeathSound()
    {
        audioSource.PlayOneShot(deathAudioClips.GetAudioClips());
    }
    
    public void PlayWinSound()
    {
        audioSource.PlayOneShot(winAudioClips.GetAudioClips());
    }
}

