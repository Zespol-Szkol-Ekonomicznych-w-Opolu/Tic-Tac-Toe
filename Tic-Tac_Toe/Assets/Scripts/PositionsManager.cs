using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionsManager : MonoBehaviour
{
    [SerializeField] List<int> CircleNumbers;
    [SerializeField] List<int> CrossNumbers;
    Tag theTag;
    Vector2 position;
    BoxCollider2D clickField;
    int tagNumber;
    WinManager winManager;
    bool somebodyWin;

    void Start(){
        theTag = FindObjectOfType<Tag>();
        clickField = GetComponent<BoxCollider2D>();
        winManager = FindObjectOfType<WinManager>();
        winManager.gameObject.SetActive(false);
    }

    public void SetPositions(Vector2 clickedPosition, int clickedNumber){
        // Don't allow to place tags when somebody has won
        if(somebodyWin){return;}
        // Sets position of the tag to clicked position
        tagNumber = clickedNumber;
        Instantiate<Tag>(theTag,clickedPosition,Quaternion.identity);
        theTag.ChangeSign();
    }

    public void isCircle(){
        CircleNumbers.Add(tagNumber);
        CheckForWin(CircleNumbers);
    }

    public void isCross(){
        CrossNumbers.Add(tagNumber);
        CheckForWin(CrossNumbers);
    }

    void CheckForWin(List<int> tagNumbers){
        // Check if current symbol has won

        // Horizontal
        if(tagNumbers.Contains(1) && tagNumbers.Contains(2) && tagNumbers.Contains(3)){
            YouWin(tagNumbers);
        }
        if(tagNumbers.Contains(4) && tagNumbers.Contains(5) && tagNumbers.Contains(6)){
            YouWin(tagNumbers);
        }
        if(tagNumbers.Contains(7) && tagNumbers.Contains(8) && tagNumbers.Contains(9)){
            YouWin(tagNumbers);
        }
        // Vertical
        if(tagNumbers.Contains(1) && tagNumbers.Contains(4) && tagNumbers.Contains(7)){
            YouWin(tagNumbers);
        }
        if(tagNumbers.Contains(2) && tagNumbers.Contains(5) && tagNumbers.Contains(8)){
            YouWin(tagNumbers);
        }
        if(tagNumbers.Contains(3) && tagNumbers.Contains(6) && tagNumbers.Contains(9)){
            YouWin(tagNumbers);
        }
        // Cross
        if(tagNumbers.Contains(1) && tagNumbers.Contains(5) && tagNumbers.Contains(9)){
            YouWin(tagNumbers);
        }
        if(tagNumbers.Contains(3) && tagNumbers.Contains(5) && tagNumbers.Contains(7)){
            YouWin(tagNumbers);
        }
    }

    void YouWin(List<int> tagNumbers){
        somebodyWin = true;
        // Activate suitable win screen
        winManager.gameObject.SetActive(true);
        if(tagNumbers == CircleNumbers){
            winManager.CircleWin();
        }
        if(tagNumbers == CrossNumbers){
            winManager.CrossWin();
        }
    }
}
