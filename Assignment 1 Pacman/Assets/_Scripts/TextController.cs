using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.SceneManagement;

public class TextController : MonoBehaviour
{
    public static TextController instance;

    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI highestPointsText;
    public TextMeshProUGUI remainedLifeText;
    public GameObject gameplayBackground;
    public GameObject gameoverBackground;
    public GameObject gamewinBackground;

    private int points = 0;
    private int highestPoints = 0;
    private int remainedLife = 3;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameplayBackground.SetActive(true);
        gameoverBackground.SetActive(false);
        gamewinBackground.SetActive(false);

        highestPoints = PlayerPrefs.GetInt("highestPoints", 0);
        pointsText.text = points.ToString() + " Points";
        highestPointsText.text = "Highest Record: " + highestPoints.ToString() + " Points";
        remainedLifeText.text = "Remained Life: " + remainedLife;

        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (remainedLife <= 0)
        {
            // freeze the scene
            // set timeScale to 1 will resume the scene
            Time.timeScale = 0;

            gameplayBackground.SetActive(false);
            gameoverBackground.SetActive(true);
        }

        if (points >= 113)
        {
            Time.timeScale = 0;

            gameplayBackground.SetActive(false);
            gamewinBackground.SetActive(true);
        }
    }

    public void ClearHighestPoints()
    {
        Debug.Log("Highest Points Record Reset");
        PlayerPrefs.SetInt("highestPoints", 0);
    }

    public void AddOnePoint()
    {
        points += 1;
        pointsText.text = points.ToString() + " Points";

        if (highestPoints < points)
        {
            PlayerPrefs.SetInt("highestPoints", points);
        } 
    }

    public void AddFivePoint()
    {
        points += 5;
        pointsText.text = points.ToString() + " Points";

        if (highestPoints < points)
        {
            PlayerPrefs.SetInt("highestPoints", points);
        }
    }

    public void LoseOneLife()
    {
        remainedLife -= 1;
        remainedLifeText.text = "Remained Life: " + remainedLife;
    }

    public void ReplayButton()
    {
        Debug.Log("Replay Button Pressed");
        EditorSceneManager.LoadScene(1);
    }

    public void ClearRecordButton()
    {
        Debug.Log("Clear Record Button Pressed");
        PlayerPrefs.SetInt("highestPoints", 0);
    }

    public void MainMenuButton()
    {
        Debug.Log("Main Menu Button Pressed");
        EditorSceneManager.LoadScene(0);
    }
}
