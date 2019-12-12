using UnityEngine;
using UnityEngine.SceneManagement;

public class GameGenerator : MonoBehaviour
{    
    public void CobaLagi()
    {       
        SceneManager.LoadScene("Stage1");
        Debug.Log("coba lagi");
    }
}
