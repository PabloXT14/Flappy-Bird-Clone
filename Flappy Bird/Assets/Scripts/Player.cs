using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D rig;

    public GameObject GameOver;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))//0: esquerdo; 1: direito;
        {
            rig.velocity = Vector2.up * Speed;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }

}
