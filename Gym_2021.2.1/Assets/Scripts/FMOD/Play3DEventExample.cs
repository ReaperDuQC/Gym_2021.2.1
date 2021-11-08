using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play3DEventExample : MonoBehaviour
{
    private FMOD.Studio.EventInstance m_instance;
    [SerializeField] private string m_path = "event:/3DeventPAth";
    private void startEvent()
    {
        m_instance = FMODUnity.RuntimeManager.CreateInstance(m_path);
        // if the game object has a rigidbody, it is possible to link it  with the gameobject instead of setting it manually every frame. when you create the event
        //FMODUnity.RuntimeManager.AttachInstanceToGameObject(m_instance, transform, GetComponent<Rigidbody>());
        m_instance.start();

    }
    private void Update()
    {
        // one option is to set it every frame
        m_instance.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));
    }
    private void StopEvent()
    {
        m_instance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }

    private bool IsPlaying()
    {
        FMOD.Studio.PLAYBACK_STATE fmodPbState;
        m_instance.getPlaybackState(out fmodPbState);

        return fmodPbState == FMOD.Studio.PLAYBACK_STATE.PLAYING;
    }
}
