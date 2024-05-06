using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ButtonStart : MonoBehaviour
{
    [SerializeField] GameObject[] Disable, Enable;

    private void OnMouseDown()
    {
        foreach (GameObject Target in Disable)
        {
            Target.SetActive(false);
        }
        foreach (GameObject Target in Enable)
        {
            Target.SetActive(true);
        }
    }
}
