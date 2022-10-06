using UnityEngine;

public class PlayerAnimatorEvents : MonoBehaviour
{
    [SerializeField] private PlayerAudioController audioController;

    public void PlayWalkSound()
    {
        audioController.PlayWalkSound();
    }
    
    public void PlayDeathSound()
    {
        audioController.PlayDeathSound();
    }
    
    public void PlayWinSound()
    {
        audioController.PlayWinSound();
    }
}
