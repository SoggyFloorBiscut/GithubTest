using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pew : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 8.0f;
    [SerializeField] GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * bulletSpeed * Time.deltaTime;
        
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
