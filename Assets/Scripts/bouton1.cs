using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public string sceneName; // Nom de la scène à charger

    public void LoadScene()
    {
        SceneManager.LoadScene(1); // Charge la scène avec le nom spécifié
    }
}
