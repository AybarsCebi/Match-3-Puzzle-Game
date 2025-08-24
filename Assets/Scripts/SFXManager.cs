using UnityEngine;

public class SFXManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static SFXManager instance;
    private void Awake()
    {
        instance = this;
    }

    public AudioSource gemSound, explodeSound, stoneSound, roundOverSound;
    public void PlayGemBreak()
    {
        gemSound.Stop();
        gemSound.pitch = Random.Range(.8f, 1.2f);
        gemSound.Play();
    }
    public void PlayExplode()
    {
        explodeSound.Stop();
        explodeSound.pitch = Random.Range(.8f, 1.2f);
        explodeSound.Play();
    }
    public void PlayStoneBreak()
    {
        stoneSound.Stop();
        stoneSound.pitch = Random.Range(.8f, 1.2f);
        stoneSound.Play();
    }
    public void PlayRoundOver()
    {
        roundOverSound.Play();
    }

}
