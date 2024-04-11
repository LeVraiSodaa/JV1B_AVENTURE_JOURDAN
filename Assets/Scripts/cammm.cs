using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow2D : MonoBehaviour
{
    private Transform playerTransform; // Référence au transform du joueur

    void Start()
    {
        // Recherche automatique du transform du joueur au démarrage
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        // Assurez-vous que le joueur existe dans la scène
        if (playerTransform == null)
        {
            Debug.LogError("Aucun objet avec le tag 'Player' trouvé dans la scène !");
        }

        // Empêcher la destruction de cet objet (et donc du script) lors du changement de scène
        DontDestroyOnLoad(gameObject);
    }

    void LateUpdate()
    {
        // Déplacer la caméra pour suivre le joueur
        if (playerTransform != null)
        {
            transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);
        }
    }

    // S'assurer que le joueur est toujours trouvé après un changement de scène
    void OnLevelWasLoaded(int level)
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        if (playerTransform == null)
        {
            Debug.LogError("Aucun objet avec le tag 'Player' trouvé dans la scène !");
        }
    }
}
