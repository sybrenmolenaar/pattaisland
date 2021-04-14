using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
            SceneManager.LoadScene(1);
            Debug.Log("LetsGo");
    }
}
