using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionsManager : MonoBehaviour
{
    [SerializeField] Transform[] positionsArray;
    Tag theTag;
    Vector2 position;
    BoxCollider2D clickField;

    void Start(){
        theTag = FindObjectOfType<Tag>();
        clickField = GetComponent<BoxCollider2D>();
    }

    public void SetPositions(Vector2 position, int positionNumber){
        // Sets position of the tag to clicked positions
        Instantiate<Tag>(theTag,position,Quaternion.identity);
        theTag.ChangeSign();
    }

    public void isCircle(){
        
    }

    public void isCross(){
        
    }
}
