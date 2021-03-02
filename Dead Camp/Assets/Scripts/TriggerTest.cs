using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTest : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {

            this.gameObject.SetActive(false);
            SceneManager.LoadScene("Death");
            //Destroy(gameObject);
        }
    }
}
