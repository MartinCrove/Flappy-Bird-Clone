using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pajaro : MonoBehaviour
{
    public float fuerzaDeSalto;

    private Rigidbody2D rb;

    public bool estaMuerto = false;

    public bool partidaEmpezada = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.gravityScale = 1;
            partidaEmpezada = true;

            if (!estaMuerto)
            {
            rb.velocity = new Vector2(0, fuerzaDeSalto);

            }
            else
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            }
        }
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!estaMuerto)
        {
            estaMuerto = true;
            rb.velocity = new Vector2 (0, 0);
        }
    }
}
