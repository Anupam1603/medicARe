using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagementMenu : MonoBehaviour
{
 public void ToHumanBody()
    {
        SceneManager.LoadScene("Prognosis");
    }
    public void backToMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }
    public void backToMenu2()
    {
        SceneManager.LoadScene("MainMenu2");

    }
    public void skeleton()
    {
        SceneManager.LoadScene("skeleton");

    }
    public void ToSystem()
    {
        SceneManager.LoadScene("System");

    }
    public void ToOrgans()
    {
        SceneManager.LoadScene("Organs");

    }
    public void ToImmune()
    {
        SceneManager.LoadScene("Immune");

    }
    public void Exit()
    {
        Application.Quit();
    }
}
