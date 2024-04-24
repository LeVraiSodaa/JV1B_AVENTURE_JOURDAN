using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    private Transform player; // Référence au transform du joueur
    public GameObject detectionCircle; // Cercle de détection
    public float followSpeed = 5f; // Vitesse de déplacement de l'ennemi pour suivre le joueur
    public float followDuration = 10f; // Durée pendant laquelle l'ennemi suit le joueur après la détection
    private bool isFollowing = false; // Indique si l'ennemi suit actuellement le joueur
    private Vector3 originalScale; // Échelle d'origine du cercle de détection

    void Start()
    {
        // Sauvegarde de l'échelle d'origine
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

            // Déplacer l'ennemi vers le joueur
            transform.position = Vector3.MoveTowards(transform.position, player.position, followSpeed * Time.deltaTime);

            // Changer l'échelle x du cercle de détection en fonction de la position du joueur
            if (player.position.x > transform.position.x)
            {
                // Si le joueur est à droite, retournez le cercle horizontalement
                detectionCircle.transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z);
            }
            else
            {
                // Si le joueur est à gauche, réinitialisez l'échelle x du cercle
                detectionCircle.transform.localScale = originalScale;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifiez si le joueur est entré dans la zone de détection
        if (other.CompareTag("Player"))
        {
            isFollowing = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Vérifiez si le joueur est sorti de la zone de détection
        if (other.CompareTag("Player"))
        {
            // Commencez à suivre pendant le délai spécifié après avoir quitté la zone
            Invoke("StopFollowing", followDuration);
        }
    }

    void StopFollowing()
    {
        isFollowing = false;
    }
}
