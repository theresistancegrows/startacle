using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class code : MonoBehaviour
{
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject resumeButton;
    [SerializeField] GameObject check;

    public void exitGame() {
        Time.timeScale = 0;
        check.SetActive(true);
    }

    public void pauseGame() {
        Time.timeScale = 0;
        pauseButton.SetActive(false);
        resumeButton.SetActive(true);
    }

    public void resumeGame() {
        Time.timeScale = 1;
        pauseButton.SetActive(true);
        resumeButton.SetActive(false);
    }

    public void yesButton() {
        Time.timeScale = 1;
        check.SetActive(false);
    }

    public void noButton() {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
