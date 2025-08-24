using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelectMenu : MonoBehaviour
{

    public string mainMenu = "Main Menu";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
