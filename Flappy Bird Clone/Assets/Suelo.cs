using UnityEngine;

public class Suelo : MonoBehaviour
{
    public Transform sueloInfinitoTransform;
    public Pajaro scriptPajaro;
    void Start()
    {

    }


    void Update()
    {
        if (!scriptPajaro.estaMuerto)
        {
            transform.position -= new Vector3(0.8f * Time.deltaTime, 0, 0);
            if (transform.position.x <= -5f)
            {
                transform.position = new Vector3(sueloInfinitoTransform.position.x + 5f, transform.position.y, transform.position.z);
            }

        }
    }
}
