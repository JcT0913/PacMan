using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class GameoverSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReplayButton()
    {
        Debug.Log("Replay Button Pressed");
        EditorSceneManager.LoadScene(1);
    }

    public void ClearRecordButton()
    {
        TextController.instance.ClearHighestPoints();
    }

    public void MainMenuButton()
    {
        Debug.Log("Main Menu Button Pressed");
        EditorSceneManager.LoadScene(0);
    }
}
