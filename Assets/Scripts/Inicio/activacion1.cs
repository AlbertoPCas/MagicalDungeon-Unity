using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activacion1 : MonoBehaviour
{
    public bool variable1;
    public bool var_1_reset;
    public GameObject llave1;

    private abrirpuerta activ_1_reseteo;

    void Start()
    {
        variable1 = false;
        var_1_reset = false;
        activ_1_reseteo = FindObjectOfType<abrirpuerta>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            variable1 = true;
            llave1.SetActive(false);
        }
    }
}