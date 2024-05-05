using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] string URL;

    private void OnMouseDown()
    {
        Application.OpenURL(URL);
    }
}
