using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    private Transform player; // R�f�rence au transform du joueur
    public GameObject detectionCircle; // Cercle de d�tection
    public float followSpeed = 5f; // Vitesse de d�placement de l'ennemi pour suivre le joueur
    public float followDuration = 10f; // Dur�e pendant laquelle l'ennemi suit le joueur apr�s la d�tection
    private bool isFollowing = false; // Indique si l'ennemi suit actuellement le joueur
    private Vector3 originalScale; // �chelle d'origine du cercle de d�tection

    void Start()
    {
        // Sauvegarde de l'�chelle d'origine
        originalScale = detectionCircle.transform.localScale;
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        if (isFollowing)
        {
            Debug.Log("Teemolaughing");
            // Faites en sorte que l'ennemi regarde toujours vers le joueur
            Vector3 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            detectionCircle.transform.rotation = Quaternion.identity; // Annule la rotation du cercle

            // D�placer l'ennemi vers le joueur
            transform.position = Vector3.MoveTowards(transform.position, player.position, followSpeed * Time.deltaTime);

            // Changer l'�chelle x du cercle de d�tection en fonction de la position du joueur
            if (player.position.x > transform.position.x)
            {
                // Si le joueur est � droite, retournez le cercle horizontalement
                detectionCircle.transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z);
            }
            else
            {
                // Si le joueur est � gauche, r�initialisez l'�chelle x du cercle
                detectionCircle.transform.localScale = originalScale;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // V�rifiez si le joueur est entr� dans la zone de d�tection
        if (other.CompareTag("Player"))
        {
            isFollowing = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // V�rifiez si le joueur est sorti de la zone de d�tection
        if (other.CompareTag("Player"))
        {
            // Commencez � suivre pendant le d�lai sp�cifi� apr�s avoir quitt� la zone
            Invoke("StopFollowing", followDuration);
        }
    }

    void StopFollowing()
    {
        isFollowing = false;
    }
}
