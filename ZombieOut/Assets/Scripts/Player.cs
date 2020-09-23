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
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}
