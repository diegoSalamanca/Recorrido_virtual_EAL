
using UnityEngine;
using UnityEngine.UI;


public class SoundManager : MonoBehaviour
{
  

    bool mute = false;

    public Image background, imgSprite;

    public Sprite audioOn, audioOff;


    public void SwitchVolumen()
    {
        var Audiosources = FindObjectsOfType<AudioSource>();

        if (!mute)
        {
            mute = true;
            background.color = Color.red;
            imgSprite.sprite = audioOff;

            foreach (var item in Audiosources)
            {
                item.volume = 0;
            }

        }
        else
        {
            background.color = Color.green;
            imgSprite.sprite = audioOn;

            foreach (var item in Audiosources)
            {
                item.volume = 1;
            }

            mute = false;
        }

        
    }
}
