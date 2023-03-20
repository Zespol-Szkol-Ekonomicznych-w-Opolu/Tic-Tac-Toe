using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag : MonoBehaviour
{
    PositionsManager positions;
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite circleSprite;
    [SerializeField] Sprite crossSprite;
    bool isCircle = true;
    void Start(){
        positions = FindObjectOfType<PositionsManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeSign(){
        // Changes the tag sign every time it is placed
        if(isCircle){
            // Circle is placed
            positions.isCircle();
            // Change to cross
            spriteRenderer.sprite = crossSprite;
            isCircle = false;
        }
        else{
            // Cross is placed
            positions.isCross();
            // Change to circle
            spriteRenderer.sprite = circleSprite;
            isCircle = true;
        }
    }
}
