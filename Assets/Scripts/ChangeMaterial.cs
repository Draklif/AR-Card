using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    [SerializeField] Material HoloMaterial;
    [SerializeField] Material DenseMaterial;

    public void ChangeToHolo()
    {
        GetComponent<MeshRenderer>().material = HoloMaterial;
    }
    public void ChangeToDense()
    {
        GetComponent<MeshRenderer>().material = DenseMaterial;
    }
}
