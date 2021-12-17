using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activacion4 : MonoBehaviour
{
    public bool variable4;
    public bool var_4_reset;
    public GameObject llave4;

    private abrirpuerta activ_4_reseteo;

    void Start()
    {
        variable4 = false;
        var_4_reset = false;
        activ_4_reseteo = FindObjectOfType<abrirpuerta>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            variable4 = true;
            llave4.SetActive(false);
        }
    }
}