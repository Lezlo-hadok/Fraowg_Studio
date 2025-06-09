using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneScripts : MonoBehaviour
{
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ChangeSceneByName(string sceneName)
    {
      SceneManager.LoadScene(sceneName);  //pick a scene by the name of the scene 
        Debug.Log("this worked");
    }

    // Update is called once per frame
    public void ChangeSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);//change the scene by the chosen index
    }

    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reload current when activiated scene
        
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); //reloads current scene
    }
    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);//loads the previous scene
    }
}
