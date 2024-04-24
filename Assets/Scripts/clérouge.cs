using UnityEngine;

public class rouge : MonoBehaviour
{
    public bool hasredkey = false;
    private void Start()
    {
        hasredkey = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision");
        // Vérifie si le joueur entre en collision avec un GameObject qui a le tag "clebleu"
        if (other.CompareTag("clerouge"))
        {
            // Si la collision est avec la clé bleue, détruis la clé
            Destroy(other.gameObject);
            hasredkey = true;
        }
        if (other.CompareTag("porterouge")){
            if (hasredkey == true)
            {
                // Si la collision est avec la clé bleue, détruis la clé
                Destroy(other.gameObject);
            }
        }
    }
}
