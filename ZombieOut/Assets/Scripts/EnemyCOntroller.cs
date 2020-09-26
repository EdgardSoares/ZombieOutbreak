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
        Vector3 _direcao = _player.transform.position - transform.position;
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + (_direcao.normalized * _enemySpeed * Time.deltaTime));
    }
}
