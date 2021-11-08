using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEventExemple : MonoBehaviour
{
    private FMOD.Studio.EventInstance m_instance;
    private void PlayEvent()
    {
        // only one instance of this event will exist at any time, so if i want a new instance each time, the creation must be moved from the start
        m_instance = FMODUnity.RuntimeManager.CreateInstance("event:/Example");
        m_instance.start();
        m_instance.release();
    }
}
