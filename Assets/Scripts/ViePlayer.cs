using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViePlayer : MonoBehaviour
{
    public int vie;
    public Sprite[] vies;
    public Image vieUI;

    // Start is called before the first frame update
    void Start()
    {
        vie = 3;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void PerteVieUI()
    {
        vieUI.sprite = vies[vie];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ennemi"))
        {
            vie -= 1;
            PerteVieUI();
            if (vie >= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}