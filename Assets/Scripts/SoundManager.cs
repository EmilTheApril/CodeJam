using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Sounds
{
    Shoot,
    Heal,
    TakeDamage
}

public class SoundManager : MonoBehaviour
{
    public AudioClip[] Clips;
    public Slider MasterVol;
    public Slider MusicVol;
    public Slider EffectsVol;
}
