using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float _eixoX;
    public float _eixoZ;
    Vector3 _direction = Vector3.zero;
    public float _speed;
    public LayerMask mascaraChao;
    public GameObject textoGameOver;
    public bool vivo = true;

    void Start()
    {
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        _eixoX = Input.GetAxis("Horizontal");
        _eixoZ = Input.GetAxis("Vertical");

        _direction = new Vector3(_eixoX, 0, _eixoZ);

        //Condicao para executar animacao de Idle para Walking
        if (_direction != Vector3.zero)
        {
            GetComponent<Animator>().SetBool("Move", true);
        } else
        {
            GetComponent<Animator>().SetBool("Move", false);
        }

        if(vivo == false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    void FixedUpdate()
    {
        //Movimentacao por segundo do jogador usando a fisica da Unity
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + _direction * _speed * Time.deltaTime);

        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * 100, Color.red);

        RaycastHit impacto;

        if(Physics.Raycast(raio, out impacto, 100, mascaraChao))
        {
            Vector3 posicaoMiraJogador = impacto.point - transform.position;
            //posicaoMiraJogador.y = transform.position.y;

            Quaternion novaRotacao = Quaternion.LookRotation(posicaoMiraJogador);
            GetComponent<Rigidbody>().MoveRotation(novaRotacao);
        }

    }
}
