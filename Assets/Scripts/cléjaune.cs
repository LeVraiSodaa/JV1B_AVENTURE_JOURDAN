using UnityEngine;

public class jaune : MonoBehaviour
{
    public bool hasyellowkey = false;
    private void Start()
    {
        hasyellowkey = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision");
        // Vérifie si le joueur entre en collision avec un GameObject qui a le tag "clebleu"
        if (other.CompareTag("clejaune"))
        {
            // Si la collision est avec la clé bleue, détruis la clé
            Destroy(other.gameObject);
            hasyellowkey = true;
        }
        if (other.CompareTag("portejaune")){
            if (hasyellowkey == true)
            {
                // Si la collision est avec la clé bleue, détruis la clé
                Destroy(other.gameObject);
            }
        }
    }
}
