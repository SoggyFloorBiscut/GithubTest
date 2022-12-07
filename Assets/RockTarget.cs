using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RockTarget : MonoBehaviour
{
    [SerializeField] float rockSpeed = 1.0f;
    [SerializeField] TextMeshProUGUI Score;
    [SerializeField] TextMeshProUGUI extra;
    int point = -1;
    // Start is called before the first frame update
    void Start()
    {
        RockReset();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            rockSpeed = 1;
            point = -1;
            RockReset();
        }
        transform.position -= new Vector3(0, rockSpeed) * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        RockReset();
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
        }
        
    }

    private void RockReset()
    {
        transform.position = new Vector3(Random.Range(-7, 7),Random.Range(6, 8));
        rockSpeed += 0.2f;
        if (extra.text == "")
        {
            point += 1;
            Score.text = "Point: " + point;
        }
        else
        {
            Score.text = "Total Score: " + point;
        }
        
    }
}
