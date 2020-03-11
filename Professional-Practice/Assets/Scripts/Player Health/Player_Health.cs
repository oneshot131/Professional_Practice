using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{
    public int health;
    public bool hasDied;

    void Start() {
        hasDied = false;
    }

    void Update() {
        if (gameObject.transform.position.y < -7) {
            hasDied = true;
        }
        if (hasDied == true) {
            StartCoroutine("Die");
        }
    }

    IEnumerator Die () {
        SceneManager.LoadScene("Main");
        yield return null;
    }


}

   /* void Die()
    {
        SceneManager.LoadScene("Prototype_1");
    } */
