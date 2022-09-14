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
        highestPoints = PlayerPrefs.GetInt("highestPoints", 0);
        pointsText.text = points.ToString() + " Points";
        highestPointsText.text = "Highest Record: " + highestPoints.ToString() + " Points";
        remainedLifeText.text = "Remained Life: " + remainedLife;

        // Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (remainedLife <= 0)
        {
            // freeze the scene
            // set timeScale to 1 will resume the scene
            // Time.timeScale = 0;
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
}
