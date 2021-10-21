using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject credits;
    [SerializeField] GameObject mainMenu;

    private void Start() {
        credits.SetActive(false);
    }

    public void loadCredits() {
        mainMenu.SetActive(false);
        credits.SetActive(true);
    }

    public void loadMainMenu() {
        credits.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void exit() {
        Application.Quit();
    }

    public void back() {
        SceneManager.LoadScene(0);
    }

    public void startGame() {
        SceneManager.LoadScene(1);
    }

    public void linkedinLink() {
        System.Diagnostics.Process.Start("https://www.linkedin.com/in/sogand-salehi-9b8624200/");
    }

    public void sketchfabLink() {
        System.Diagnostics.Process.Start("https://sketchfab.com/");
    }

}
