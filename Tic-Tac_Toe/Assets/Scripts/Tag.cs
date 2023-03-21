using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] Sprite circleSprite;
    [SerializeField] Sprite crossSprite;
    PositionsManager positions;
    SpriteRenderer spriteRenderer;
    bool isCircle = true;
    void Start(){
        positions = FindObjectOfType<PositionsManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    public void ChangeSign(){
        // Changes the tag sign every time it is placed
        if(isCircle){
            // Circle is placed
            positions.isCircle();
            audioSource.Play();
            // Change to cross
            spriteRenderer.sprite = crossSprite;
            isCircle = false;
        }
        else{
            // Cross is placed
            positions.isCross();
            audioSource.Play();
            // Change to circle
            spriteRenderer.sprite = circleSprite;
            isCircle = true;
        }
    }
}
