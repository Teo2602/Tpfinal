using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
   void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Win"))
        {
            SceneManager.LoadScene("Win");
        }
    }

}
