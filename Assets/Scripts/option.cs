using UnityEngine;
using UnityEngine.SceneManagement;

public class option : MonoBehaviour
{
    public string sceneName; // Nom de la scène à charger

    public void LoadScene()
    {
        SceneManager.LoadScene(2); // Charge la scène avec le nom spécifié
    }
}
