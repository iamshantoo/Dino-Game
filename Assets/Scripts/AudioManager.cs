using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource Jump;
    public AudioSource Die;
    public AudioSource Score;
    public AudioSource Background;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void PlayJump()
    {
        Jump.Play();
    }

    public void PlayDie()
    {
        Die.Play();
    }

    public void PlayScore()
    {
        Score.Play();
    }

    public void PlayBackground()
    {
        Background.Play();
    }
}
