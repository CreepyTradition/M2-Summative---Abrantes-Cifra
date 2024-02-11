using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxController : MonoBehaviour
{
    private bool impact;
    public AudioSource boxSoundSource;
    public AudioClip boxSoundClip;

    void OnTriggerEnter(Collider itemGet)
    {
        if(itemGet.gameObject.tag == "Player")
        {
            ItemBoxDestroy();
            playBoxSound();
        }
    }

    void ItemBoxDestroy()
    {
        Destroy(gameObject);
    }

    void playBoxSound()
    {
        if (boxSoundClip != null)
        {
            boxSoundSource.clip = boxSoundClip;
            if (!boxSoundSource.enabled)
            {
                boxSoundSource.enabled = true;
            }
            Debug.Log("Played");
            boxSoundSource.Play();
        }
    }
}
