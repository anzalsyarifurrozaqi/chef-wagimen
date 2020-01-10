using UnityEngine;
using UnityEngine.SceneManagement;

public class ToBoss2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Boss2");
        }
	}
}
