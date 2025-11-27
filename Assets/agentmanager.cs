using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class agentmanager : MonoBehaviour
{
    [SerializeField] Transform obj;
    [SerializeField] NavMeshAgent agente;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agente.destination = obj.position;
        if(agente.path!=null && agente.remainingDistance < 0.5)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
