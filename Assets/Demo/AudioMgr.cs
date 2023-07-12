using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioMgr : MonoBehaviour
{
    public CharacterController cc;
    public SoundFXData[] sfxs;
    
    // Start is called before the first frame update
    void Start()
    {
        cc.done += PressedKeyboard;
    }

    private void PressedKeyboard(int index)
    {
        print($"done {index}");
    }
}

public enum Character { Bobo, Mo }
[Serializable]
public class SoundFXData
{
    public Character character;
    public AudioClip jump;
    public AudioClip hand;
}