using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        Debug.Log("Play Button pressed");
        EditorSceneManager.LoadScene(1);

        // another method
        // EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitButton()
    {
        Debug.Log("Exit Button pressed");
        Application.Quit();
    }
}
