using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] KeyCode right;
    [SerializeField] KeyCode left;
    [SerializeField] KeyCode up;
    [SerializeField] KeyCode shoot;
    [SerializeField] float speed = 150.0f;
    [SerializeField] int ammo = 3;
    float loadAmmo;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform spawnPoint;
    [SerializeField] TextMeshProUGUI shoots;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right))
        {
            transform.eulerAngles -= new Vector3(0, 0, speed) * Time.deltaTime;

        }
        if (Input.GetKey(left))
        {
            transform.eulerAngles += new Vector3(0, 0, speed) * Time.deltaTime;

        }
        if (Input.GetKey(up))
        {
            transform.position += new Vector3(0, speed);
        }
        if (Input.GetKeyDown(shoot) && ammo >= 1)
        {
            ammo -= 1;
            Instantiate(bullet, transform.position, transform.rotation);
            shoots.text = "" + ammo;
        }
        if (ammo < 3)
        {
            loadAmmo += Time.deltaTime;
            if (loadAmmo > 1.0f)
            {
                loadAmmo = 0;
                ammo += 1;
                shoots.text = "" + ammo;
            }
        }
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            ammo = 3;
            shoots.text = "" + ammo;
            loadAmmo = 0;
        }
    }
}
