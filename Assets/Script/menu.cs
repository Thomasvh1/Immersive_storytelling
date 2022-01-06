using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void LoadScene( string scene)
    {
        var AllScene = SceneManager.GetAllScenes();
        foreach (var currentScene in AllScene)
        {
            SceneManager.UnloadScene(currentScene);
        }
        SceneManager.LoadScene(scene);
    }

    // Update is called once per frame
    
}
