using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCOntroller : MonoBehaviour
{

    public GameObject _player;
    public float _enemySpeed;
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
        

        float _distance = Vector3.Distance(transform.position, _player.transform.position); //calcular a distance entre o inimigo e o jogador

        if(_distance > 2.5)
        {
            Vector3 _direcao = _player.transform.position - transform.position; //calcular a direcao entre o jogador e o inimigo
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + (_direcao.normalized * _enemySpeed * Time.deltaTime)); //fazer movimentar, seguir o inimigo ate o jogador

            Quaternion _rotation = Quaternion.LookRotation(_direcao); //calcular a rotacao que o inimigo tem que fazer em direcao ao jogador
            GetComponent<Rigidbody>().MoveRotation(_rotation); //fazer com o que o inimigo faca a rotacao em direcao ao jogador
        }
    }
}
