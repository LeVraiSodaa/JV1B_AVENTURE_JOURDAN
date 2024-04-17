using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    public bool hasbluekey = false;
    private void Start()
    {
        hasbluekey = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision");
        // Vérifie si le joueur entre en collision avec un GameObject qui a le tag "clebleu"
        if (other.CompareTag("clebleu"))
        {
            // Si la collision est avec la clé bleue, détruis la clé
            Destroy(other.gameObject);
            hasbluekey = true;
        }
        if (other.CompareTag("portebleu")){
            if (hasbluekey == true)
            {
                // Si la collision est avec la clé bleue, détruis la clé
                Destroy(other.gameObject);
            }
        }
    }
}
