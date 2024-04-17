using UnityEngine;

public class GestionZoneDéclenchement : MonoBehaviour
{
    public GameObject[] objetsAActiver;


    private void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifie si le joueur entre en collision avec la zone de déclenchement
        if (other.CompareTag("Player"))
        {
            // Active les objets et rend-les complètement opaques
            foreach (GameObject objet in objetsAActiver)
            {
                objet.SetActive(true); // Active le GameObject
                Invoke("DesactiveDoors", 5f);
            }
        }
    }
    void DesactiveDoors()
    {
        foreach (GameObject objet in objetsAActiver)
        {
            objet.SetActive(false); // Active le GameObject
        }
    }
}
