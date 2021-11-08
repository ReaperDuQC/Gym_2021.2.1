using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayLoopExample : MonoBehaviour
{
    private FMOD.Studio.EventInstance m_instance;

    private void StartLoop()
    {
        m_instance = FMODUnity.RuntimeManager.CreateInstance("event:/Example");
        m_instance.start();
    }

    private void StopLoop()
    {
        m_instance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        m_instance.release();
    }
}
