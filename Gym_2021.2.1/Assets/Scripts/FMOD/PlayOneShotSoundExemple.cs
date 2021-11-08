using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOneShotSoundExemple : MonoBehaviour
{
    // Start is called before the first frame update
    private void PlayOneShot()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Example copy paste path from fmod");
    }
}
