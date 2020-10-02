using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZumbi : MonoBehaviour
{

    public GameObject _zombi;
    float _contTime;
    public float TimeSpawnZombi = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _contTime += Time.deltaTime;

        if(_contTime >= TimeSpawnZombi)
        {
            Instantiate(_zombi, transform.position, transform.rotation);
            _contTime = 0;
        }
    }
}
