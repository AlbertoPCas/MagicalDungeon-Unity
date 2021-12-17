using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Jugador : MonoBehaviour
{
    public float velocidad = 500f;
    Rigidbody rb;
    public GameObject Player;
    public GameObject posicionreinicio;
    public GameObject posicionreinicio2;
    private Animator anim;
    public float movement;
    public GameObject imagen_gema_verde;
    public GameObject imagen_gema_azul;
    public GameObject imagen_gema_roja;
    public GameObject gema_verde2;
    public GameObject gema_azul2;
    public GameObject gema_roja2;
    public static bool bool_gema; // sera true cuando la cojas
    public GameObject particulas_gema_azul;
    public GameObject particulas_gema_verde;
    public GameObject particulas_gema_roja;
    public AudioSource error;
    public AudioSource gema;
    public AudioSource fantasma;
    public AudioSource musica;




    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        imagen_gema_azul.gameObject.SetActive(false);
        imagen_gema_verde.gameObject.SetActive(false);
        imagen_gema_roja.gameObject.SetActive(false);
        particulas_gema_azul.gameObject.SetActive(false);
        particulas_gema_verde.gameObject.SetActive(false);
        particulas_gema_roja.gameObject.SetActive(false);
        gema_verde2.gameObject.SetActive(false);
        gema_azul2.gameObject.SetActive(false);
        gema_roja2.gameObject.SetActive(false);
        musica.Play();
    }


    void Update()
    {
        
        float MovimientoHorizontal = Input.GetAxis("Horizontal");
        float MovimientoVertical = Input.GetAxis("Vertical");

        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.01 || Mathf.Abs(Input.GetAxis("Vertical")) > 0.01)
            movement = 0.02f;
        else
            movement = 0f;

        anim.SetFloat("walk", Mathf.Abs(movement));
        anim.SetFloat("walk", Mathf.Abs(movement));
        

        Vector3 Move = new Vector3(MovimientoHorizontal, 0.0f, MovimientoVertical);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Move), 0.15F);
        rb.AddForce(Move * velocidad * Time.deltaTime);
  







    }
    private void OnTriggerEnter(Collider other)
    {
      if (other.gameObject.tag == "fallo")
      {
            Player.transform.position = posicionreinicio.transform.position;
            error.Play();
      }
        //DAR PUNTO

        if (other.gameObject.tag == "GemaVerde")  //
        {
            other.gameObject.SetActive(false);
            imagen_gema_verde.gameObject.SetActive(true);
            particulas_gema_verde.gameObject.SetActive(true);
            Destroy(particulas_gema_verde, 1f);
            gema_verde2.gameObject.SetActive(true);
            gema.Play();
        }

        if (other.gameObject.tag == "GemaAzul")  //
        {
            other.gameObject.SetActive(false); //DESTRUYE EL OBJETO
            imagen_gema_azul.gameObject.SetActive(true);
            particulas_gema_azul.gameObject.SetActive(true);
            Destroy(particulas_gema_azul, 1f);
            gema_azul2.gameObject.SetActive(true);
            gema.Play();

        }
        if (other.gameObject.tag == "GemaRoja")  //
        {
            other.gameObject.SetActive(false); //DESTRUYE EL OBJETO
            imagen_gema_roja.gameObject.SetActive(true);
            particulas_gema_roja.gameObject.SetActive(true);
            Destroy(particulas_gema_roja, 1f);
            gema_roja2.gameObject.SetActive(true);
            gema.Play();

        }
        if (other.gameObject.tag == "fantasma")
        {
            Player.transform.position = posicionreinicio2.transform.position;
            fantasma.Play();
        }
        if (other.gameObject.tag == "final")
        {
            SceneManager.LoadScene(3);
        }
        
        

    }
}