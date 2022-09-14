using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class ReturnButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnToMenuButton()
    {
        Debug.Log("Return to Menu Button Pressed");
        EditorSceneManager.LoadScene(0);
    }
}
