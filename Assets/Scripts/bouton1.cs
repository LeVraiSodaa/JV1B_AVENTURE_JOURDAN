using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public string sceneName; // Nom de la sc�ne � charger

    public void LoadScene()
    {
        SceneManager.LoadScene(1); // Charge la sc�ne avec le nom sp�cifi�
    }
}
