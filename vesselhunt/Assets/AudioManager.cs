using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("----------Audio Sources-------")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;

    [Header("----------Audio Clips-------")]
    public AudioClip background;
    public AudioClip footsteps;
    public AudioClip wind;
    public AudioClip ambience;

    private void Start()
    {
        musicSource.clip = wind;
        musicSource.Play();
    }

    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        bool isMoving = moveX != 0 || moveY != 0;

        if (isMoving)
        {
            if (!sfxSource.isPlaying)
            {
                sfxSource.clip = footsteps;
                sfxSource.loop = true;
                sfxSource.Play();
            }
        }
        else
        {
            if (sfxSource.isPlaying)
            {
                sfxSource.Stop();
            }
        }
    }
}


 
