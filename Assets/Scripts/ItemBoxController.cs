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
        }
    }

    void ItemBoxDestroy()
    {
        Destroy(gameObject);
    }
}
