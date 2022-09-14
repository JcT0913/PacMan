using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextController : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI highestPointsText;

    private int points = 0;
    private int highestPoints = 0;

    // Start is called before the first frame update
    void Start()
    {
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
    }
}
