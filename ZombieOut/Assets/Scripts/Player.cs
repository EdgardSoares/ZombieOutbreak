using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float _eixoX;
    public float _eixoZ;
    Vector3 _direction = Vector3.zero;
    public float _speed;
    // Update is called once per frame
    void Update()
    {
        _eixoX = Input.GetAxis("Horizontal");
        _eixoZ = Input.GetAxis("Vertical");

        _direction = new Vector3(_eixoX, 0, _eixoZ);

        if (_direction != Vector3.zero)
        {
            GetComponent<Animator>().SetBool("Move", true);
        } else
        {
            GetComponent<Animator>().SetBool("Move", false);
        }
    }

    void FixedUpdate()
    {
        //Movimentacao por segundo do jogador usando a fisica da Unity
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + _direction * _speed * Time.deltaTime);
    }
}
