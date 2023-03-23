using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    [SerializeField] AudioClip drawSound;
    [SerializeField] AudioClip playAgainSound;
    [SerializeField] AudioClip winSound;
    [SerializeField] AudioSource audioSource;
    [SerializeField] TextMeshProUGUI winText;
    [SerializeField] GameObject tagImg;
    [SerializeField] Sprite circleImg;
    [SerializeField] Sprite crossImg;

    public void CircleWin(){
        // Show circle win screen
        winText.text = "Circle Wins!";
        tagImg.GetComponent<Image>().sprite = circleImg;
        audioSource.clip = winSound;
        audioSource.Play();
    }

    public void CrossWin(){
        // Show cross win screen
        winText.text = "Cross Wins!";
        tagImg.GetComponent<Image>().sprite = crossImg;
        audioSource.clip = winSound;
        audioSource.Play();
    }

    public void PlayAgain(){
        audioSource.clip = playAgainSound;
        audioSource.Play();
        StartCoroutine(ReloadScene());
    }

    IEnumerator ReloadScene(){
        yield return new WaitForSecondsRealtime(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Draw(){
        // Show draw screen
        winText.text = "Draw!";
        tagImg.GetComponent<Image>().enabled = false;
        audioSource.clip = drawSound;
        audioSource.Play();
    }
}
