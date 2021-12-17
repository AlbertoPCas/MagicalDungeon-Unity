using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciarenemigo : MonoBehaviour
{
    public Transform elobjeto;
    public float fireRate;
    public float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(elobjeto, new Vector3(Random.Range(0, 10), 76, -65), Quaternion.identity);

        }

        //StartCoroutine("salir", 10);
    }
    IEnumerator salir (float t)
    {
        yield return new WaitForSeconds(t);
        yield return null;
    }
}
