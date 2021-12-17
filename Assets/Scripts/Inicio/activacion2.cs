using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activacion2 : MonoBehaviour
{
    public bool variable2;
    public bool var_2_reset;
    public GameObject llave2;

    private abrirpuerta activ_2_reseteo;

    void Start()
    {
        variable2 = false;
        var_2_reset = false;
        activ_2_reseteo = FindObjectOfType<abrirpuerta>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            variable2 = true;
            llave2.SetActive(false);
        }
    }
}