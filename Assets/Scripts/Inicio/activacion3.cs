using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activacion3 : MonoBehaviour
{
    public bool variable3;
    public bool var_3_reset;
    public GameObject llave3;

    private abrirpuerta activ_3_reseteo;

    void Start()
    {
        variable3 = false;
        var_3_reset = false;
        activ_3_reseteo = FindObjectOfType<abrirpuerta>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            variable3 = true;
            llave3.SetActive(false);
        }
    }
}