using UnityEngine;

public class vert : MonoBehaviour
{
    public bool hasgreenkey = false;
    private void Start()
    {
        hasgreenkey = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision");
        // Vérifie si le joueur entre en collision avec un GameObject qui a le tag "clebleu"
        if (other.CompareTag("cleverte"))
        {
            // Si la collision est avec la clé bleue, détruis la clé
            Destroy(other.gameObject);
            hasgreenkey = true;
        }
        if (other.CompareTag("porteverte")){
            if (hasgreenkey == true)
            {
                // Si la collision est avec la clé bleue, détruis la clé
                Destroy(other.gameObject);
            }
        }
    }
}
