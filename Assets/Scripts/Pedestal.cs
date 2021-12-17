using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestal : MonoBehaviour
{
    public GameObject gema_verde2;
    public GameObject gema_azul2;
    public GameObject gema_roja2;
    public GameObject puerta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((gema_azul2.activeInHierarchy) && (gema_verde2.activeInHierarchy) && (gema_roja2.activeInHierarchy))
        {
            Destroy(puerta);
       
        }
    }
}
