using UnityEngine;

[AddComponentMenu("Hammer SandBox Tools SDK/Sound/AnimSound")]
public class AnimSound : MonoBehaviour
{
    public AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip sound)
    {
        source.PlayOneShot(sound);
    }
}
