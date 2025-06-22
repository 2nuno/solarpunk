using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneToggle : MonoBehaviour
{
    // Names of the two scenes you want to toggle between
    [SerializeField] private string sceneA = "Oud Catharijne";
    [SerializeField] private string sceneB = "Solar Catharijne";

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Change KeyCode if needed
        {
            ToggleScene();
        }
    }

    private void ToggleScene()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == sceneA)
        {
            SceneManager.LoadScene(sceneB);
        }
        else if (currentScene == sceneB)
        {
            SceneManager.LoadScene(sceneA);
        }
        else
        {
            Debug.LogWarning("Current scene is not SceneA or SceneB");
        }
    }
}
