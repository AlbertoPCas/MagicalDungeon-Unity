using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perseguir : MonoBehaviour
{


    public float attackRadius;  // radio de ataque para el enemigo
    public float visionRadius;  // radio de vision para el enemigo
    public float speed;         // velocidad a la que te persigue

    private GameObject player;  // al que persigue

    private Vector3 initialposition;     // guardar la posición inicial


    void Start()
    {
        player = GameObject.Find("Player");     // asocia el Player con su variable
        initialposition = transform.position;   // se guarda su posición inicial

    }

    void Update()
    {

        Vector3 target = initialposition;  // hasta que no se acerque el player, el target es su posicion inicial
        transform.LookAt(player.transform);
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist < visionRadius)
        {
            target = player.transform.position;

            // transform.position += transform.forward * speed * Time.deltaTime;
        }


        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
     

        Debug.DrawLine(transform.position, target, Color.green);  // dibuja una linea en la pestaña escena para ver como se mueve el enemigo
        
    }

    // esto no vale para nada -- solo para ver el área de acción!!
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, visionRadius);
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }
}

