using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextController : MonoBehaviour
{
    public static TextController instance;

    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI highestPointsText;

    private int points = 0;
    private int highestPoints = 0;

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
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
