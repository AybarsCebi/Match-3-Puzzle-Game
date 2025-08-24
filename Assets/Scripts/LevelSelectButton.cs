using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelectButton : MonoBehaviour
{
    public string levelToLoad;
    public GameObject star1, star2, star3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
        if (PlayerPrefs.HasKey(levelToLoad + "_Star1"))
        {
            star1.SetActive(true);
        }
        if (PlayerPrefs.HasKey(levelToLoad + "_Star2"))
        {
            star2.SetActive(true);
        }
        if (PlayerPrefs.HasKey(levelToLoad + "_Star3"))
        {
            star3.SetActive(true);
        }
    }

    // Update is called once per frame
    public void LoadLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
