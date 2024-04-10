using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothing;

    // Start is called before the first frame update
    void Start()
    {
        //�vite la destruction au chargement de la sc�ne
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //r�cup�re la position du joueur puis y va
        if (transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }

    }
}