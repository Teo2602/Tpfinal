using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] Transform camara;
    [SerializeField] float  distancia;
    [SerializeField] Transform jugador;
    [SerializeField] float Fuerza;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(camara.position, camara.forward, out RaycastHit hit, distancia))
        {
            if("Bola"==hit.collider.name)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Rigidbody rb = hit.collider.GetComponent<Rigidbody>();
                    EmpujarBola(rb, Fuerza);
                }
            }
        }
        Gizmos.color=Color.red;
        Debug.DrawRay(camara.position, camara.forward * distancia, Gizmos.color);
    }
    void EmpujarBola(Rigidbody rbBola, float fuerza)
    {
        Vector3 direccion = jugador.forward;
        rbBola.AddForce(direccion * fuerza, ForceMode.Impulse);
    }
}
