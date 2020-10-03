using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControll : MonoBehaviour
{
    public GameObject _bullet;
    public GameObject _CanoDaArma;
    public AudioSource _bulletsound;

    
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(_bullet, _CanoDaArma.transform.position, _CanoDaArma.transform.rotation);
            _bulletsound.Play();
            
        }
    }
}
