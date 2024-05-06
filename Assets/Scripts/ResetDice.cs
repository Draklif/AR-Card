using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetDice : MonoBehaviour
{
    [SerializeField] GameObject SpawnPos;
    [SerializeField] GameObject Dice;

    private void OnMouseDown()
    {
        Dice.transform.position = SpawnPos.transform.position;
        Dice.transform.rotation = Random.rotation;
    }
}
