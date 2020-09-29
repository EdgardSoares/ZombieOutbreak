using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject _jogador;
    public float _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float _distancia = Vector3.Distance(transform.position, _jogador.transform.position);
        if(_distancia > 2)
        {
            Vector3 _direcao = _jogador.transform.position - transform.position;
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + _direcao.normalized * _speed * Time.deltaTime);

            Quaternion _rotacao = Quaternion.LookRotation(_direcao);
            GetComponent<Rigidbody>().MoveRotation(_rotacao);
        }
        
       

    }
}
