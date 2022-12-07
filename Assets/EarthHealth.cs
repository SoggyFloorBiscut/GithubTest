using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EarthHealth : MonoBehaviour
{
    int hp = 3;
    [SerializeField] TextMeshProUGUI health;
    [SerializeField] TextMeshProUGUI extra;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            hp = 3;
            extra.text = "";
            health.text = "HP: " + hp;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Rock")
        {
            if (hp == 1)
            {
                health.text = "Game Over";
                extra.text = "R = Restart";
            }
            else
            {
                hp -= 1;
                health.text = "HP: " + hp;
            }
        }
        
    }
}
