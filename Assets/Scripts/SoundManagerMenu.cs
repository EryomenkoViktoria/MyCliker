using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerMenu : MonoBehaviour
{
    [SerializeField]
    AudioClip buttonClik, clik, bonus;

    public static SoundManagerMenu inst;

    void Awake()
    {
        inst = this;
    }

    internal void PlaySound(AudioClip clip, float vol = 1)
    {
        if (Camera.main != null)
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, vol);
    }

    internal void ButtonClik()
    {
        PlaySound(buttonClik);
    }

    internal void Clic()
    {
        PlaySound(clik);
    }

    internal void Bonus()
    {
        PlaySound(bonus);
    }
}
