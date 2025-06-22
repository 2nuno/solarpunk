using UnityEngine;
using TMPro;

public class SolarpunkVisionPrompt : MonoBehaviour
{
    public TextMeshProUGUI promptText;
    public float showDelay = 3f;

    private void Start()
    {
        if (!SessionState.hasActivatedSolarpunkVision)
        {
            promptText.gameObject.SetActive(false);
            Invoke(nameof(ShowPrompt), showDelay);
        }
        else
        {
            promptText.gameObject.SetActive(false);
        }
    }

    void ShowPrompt()
    {
        if (!SessionState.hasActivatedSolarpunkVision)
        {
            promptText.gameObject.SetActive(true);
        }
    }

    private void Update()
    {
        if (!SessionState.hasActivatedSolarpunkVision && Input.GetKeyDown(KeyCode.E))
        {
            SessionState.hasActivatedSolarpunkVision = true;
            promptText.gameObject.SetActive(false);

            // TODO: Add your solarpunk vision effect here
            Debug.Log("Solarpunk vision activated!");
        }
    }
}
