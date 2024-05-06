using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ButtonMute : MonoBehaviour
{
    [SerializeField] VideoPlayer Video;
    [SerializeField] Material MutedMaterial;
    [SerializeField] Material UnmutedMaterial;
    bool muted = false;

    private void OnMouseDown()
    {
        muted = !muted;
        Video.SetDirectAudioMute(0, muted);

        if (muted)
        {
            GetComponent<MeshRenderer>().material = MutedMaterial;
        } 
        else
        {
            GetComponent<MeshRenderer>().material = UnmutedMaterial;
        }
    }
}
