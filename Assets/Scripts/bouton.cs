using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName; // Nom de la scène à charger

    public void LoadScene()
    {
        SceneManager.LoadScene(0); // Charge la scène avec le nom spécifié
    }
}
