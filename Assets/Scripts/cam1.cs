using UnityEngine;

public class GestionZoneD�clenchement : MonoBehaviour
{
    public GameObject[] objetsAActiver;


    private void OnTriggerEnter2D(Collider2D other)
    {
        // V�rifie si le joueur entre en collision avec la zone de d�clenchement
        if (other.CompareTag("Player"))
        {
            // Active les objets et rend-les compl�tement opaques
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
