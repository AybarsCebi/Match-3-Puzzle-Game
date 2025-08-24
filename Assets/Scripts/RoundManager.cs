using UnityEngine;
using UnityEngine.SceneManagement;
public class RoundManager : MonoBehaviour
{
    public float roundTime = 60f;
    private UIManager uiMain;
    private bool endingRound = false;
    private Board board;
    public int currentScore;
    public float displayScore;
    public float scoreSpeed;
    public int scoreTarget1, scoreTarget2, scoreTarget3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiMain = FindAnyObjectByType<UIManager>();
        board = FindAnyObjectByType<Board>();
    }

    // Update is called once per frame
    void Update()
    {
        if (roundTime > 0)
        {
            roundTime -= Time.deltaTime;
            if (roundTime <= 0)
            {
                roundTime = 0;
                endingRound = true;
            }
        }
        if (endingRound && board.currentState == Board.BoardState.move)
        {
            winCheck();
            endingRound = false;
        }
        uiMain.timeText.text = roundTime.ToString("0.0") + "s";
        displayScore = Mathf.Lerp(displayScore, currentScore, scoreSpeed*Time.deltaTime);
        uiMain.scoreText.text = displayScore.ToString("0");
    }

    private void winCheck()
    {
        uiMain.roundOverScreen.SetActive(true);
        uiMain.winScore.text = currentScore.ToString();
        if (currentScore >= scoreTarget3)
        {
            uiMain.winText.text = "Congralutions! You earned 3 stars!";
            uiMain.winStars3.SetActive(true);
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name + "_Star1", 1);
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name + "_Star2", 1);
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name + "_Star3", 1);
        }
        else if (currentScore >= scoreTarget2)
        {
            uiMain.winText.text = "Congralutions! You earned 2 stars!";
            uiMain.winStars2.SetActive(true);
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name + "_Star1", 1);
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name + "_Star2", 1);
        }
        else if (currentScore >= scoreTarget1)
        {
            uiMain.winText.text = "Congralutions! You earned 1 stars!";
            uiMain.winStars1.SetActive(true);
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name + "_Star1", 1);
        }
        else
        {
            uiMain.winText.text = "Oh no! No Stars for you, try again?";

        }
        SFXManager.instance.PlayRoundOver();
    }
}
