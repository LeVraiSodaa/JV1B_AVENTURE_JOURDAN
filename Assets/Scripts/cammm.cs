using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow2D : MonoBehaviour
{
    private Transform playerTransform; // R�f�rence au transform du joueur

    void Start()
    {
        // Recherche automatique du transform du joueur au d�marrage
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        // Assurez-vous que le joueur existe dans la sc�ne
        if (playerTransform == null)
        {
            Debug.LogError("Aucun objet avec le tag 'Player' trouv� dans la sc�ne !");
        }

        // Emp�cher la destruction de cet objet (et donc du script) lors du changement de sc�ne
        DontDestroyOnLoad(gameObject);
    }

    void LateUpdate()
    {
        // D�placer la cam�ra pour suivre le joueur
        if (playerTransform != null)
        {
            transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);
        }
    }

    // S'assurer que le joueur est toujours trouv� apr�s un changement de sc�ne
    void OnLevelWasLoaded(int level)
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        if (playerTransform == null)
        {
            Debug.LogError("Aucun objet avec le tag 'Player' trouv� dans la sc�ne !");
        }
    }
}
