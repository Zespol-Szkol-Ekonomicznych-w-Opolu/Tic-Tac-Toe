using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    PositionsManager positionsManager;
    [SerializeField] int myNumber;

    void Start(){
        positionsManager = FindObjectOfType<PositionsManager>();
    }

    void OnMouseDown(){
        positionsManager.SetPositions(transform.position, myNumber);
        gameObject.SetActive(false);
    }
}
