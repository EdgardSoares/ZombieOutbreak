 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject _player;
    Vector3 _distanciaCam;
    // Start is called before the first frame update
    void Start()
    {
        _distanciaCam = transform.position - _player.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _player.transform.position + _distanciaCam;
    }
}
