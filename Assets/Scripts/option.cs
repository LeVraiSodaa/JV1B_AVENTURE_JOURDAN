using UnityEngine;
using UnityEngine.SceneManagement;

public class option : MonoBehaviour
{
    public string sceneName; // Nom de la sc�ne � charger

    public void LoadScene()
    {
        SceneManager.LoadScene(2); // Charge la sc�ne avec le nom sp�cifi�
    }
}
