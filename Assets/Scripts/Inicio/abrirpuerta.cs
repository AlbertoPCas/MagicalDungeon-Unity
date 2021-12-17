using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirpuerta : MonoBehaviour
{
    public GameObject puerta;
    public bool puertaabriendo;

    public GameObject llave1;
    public GameObject llave2;
    public GameObject llave3;
    public GameObject llave4;

    public int[] orden_tocados = new int[4];
    public int num_t;

    private activacion1 act_1;
    private activacion2 act_2;
    private activacion3 act_3;
    private activacion4 act_4;

    void Start()
    {
        act_1 = FindObjectOfType<activacion1>();
        act_2 = FindObjectOfType<activacion2>();
        act_3 = FindObjectOfType<activacion3>();
        act_4 = FindObjectOfType<activacion4>();

        num_t = 4;
        puertaabriendo = false;
    }

    void Update()
    {
        if (act_1.variable1 == true)
        {
            orden_tocados[num_t] = 1;
            num_t++;
            GameObject.Find("rojo1").GetComponent<Renderer>().material.color = Color.green;

            act_1.variable1 = false;
        }

        if (act_2.variable2 == true)
        {
            orden_tocados[num_t] = 2;
            num_t++;
            GameObject.Find("rojo2").GetComponent<Renderer>().material.color = Color.green;

            act_2.variable2 = false;
        }

        if (act_3.variable3 == true)
        {
            orden_tocados[num_t] = 3;
            num_t++;
            GameObject.Find("rojo3").GetComponent<Renderer>().material.color = Color.green;

            act_3.variable3 = false;
        }

        if (act_4.variable4 == true)
        {
            orden_tocados[num_t] = 4;
            num_t++;
            GameObject.Find("rojo4").GetComponent<Renderer>().material.color = Color.green;

            act_4.variable4 = false;
        }

        if (puertaabriendo == true)
        {
            puerta.transform.Translate(Vector3.up * Time.deltaTime * -1);
            Destroy(puerta, 5f);
        }

        comprobar();
    }

    void comprobar()
    {
        if (1 == orden_tocados[0] && 2 == orden_tocados[1] && 3 == orden_tocados[2] && 4 == orden_tocados[3])
        {
            puertaabriendo = true;
        }

        else if (num_t == 4)
        {
            StartCoroutine("tiemporeset");
        }
    }

    IEnumerator tiemporeset()
    {
        yield return new WaitForSeconds(2);
        orden_tocados[0] = 0;
        orden_tocados[1] = 0;
        orden_tocados[2] = 0;
        orden_tocados[3] = 0;
        num_t = 0;

        llave1.SetActive(true);
        llave2.SetActive(true);
        llave3.SetActive(true);
        llave4.SetActive(true);

        GameObject.Find("rojo1").GetComponent<Renderer>().material.color = Color.red;
        GameObject.Find("rojo2").GetComponent<Renderer>().material.color = Color.red;
        GameObject.Find("rojo3").GetComponent<Renderer>().material.color = Color.red;
        GameObject.Find("rojo4").GetComponent<Renderer>().material.color = Color.red;
    }
}
