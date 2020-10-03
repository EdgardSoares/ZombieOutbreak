using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject _jogador;
    public float _speed;
    public AudioSource _zombieSound;
 
    // Start is called before the first frame update
    void Start()
    {
        _jogador = GameObject.FindWithTag("Player");
        _zombieSound = GetComponent<AudioSource>();
        _zombieSound.Play();
     
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 _direcao = _jogador.transform.position - transform.position;
        float _distancia = Vector3.Distance(transform.position, _jogador.transform.position);
        Quaternion _rotacao = Quaternion.LookRotation(_direcao);
        GetComponent<Rigidbody>().MoveRotation(_rotacao);

        if (_distancia > 2.5)
        {
            
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + _direcao.normalized * _speed * Time.deltaTime);
            GetComponent<Animator>().SetBool("Atacando", false);


        } else
        {
            GetComponent<Animator>().SetBool("Atacando", true);
        }
        
       

    }

    void AtacandoJogador()
    {
        Time.timeScale = 0;
        _jogador.GetComponent<Player>().textoGameOver.SetActive(true);
        _jogador.GetComponent<Player>().vivo = false;
       
    }
}
