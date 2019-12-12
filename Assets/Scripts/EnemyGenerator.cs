using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public static EnemyGenerator instantiate;
    GameObject[] enemys;
    GameObject player;
    float[] objectsDistance;
    public float distance;
    public bool die = false;
    public int i;
    int j = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (instantiate == null)
        {
            instantiate = this;
        }
        enemys = GameObject.FindGameObjectsWithTag("Enemy");
        player = GameObject.FindWithTag("Player");
        i = 0;
        objectsDistance = new float[enemys.Length];
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(enemys.Length);
        //Debug.Log("i " + i);
        //Debug.Log("j " + j);
        //Debug.Log(enemys[i].transform.position.x);
        getStatus();
        
        if (player.transform.position.x < enemys[i].transform.position.x)
        {
            objectsDistance[j] = Mathf.Abs(enemys[i].transform.position.x - player.transform.position.x);
        }
        else
        {
            objectsDistance[j] = Mathf.Abs(player.transform.position.x - enemys[i].transform.position.x);
        }
        
        getDistance();
    }

    void getDistance()
    {    
        distance = objectsDistance[j];
        //Debug.Log("distance"+ distance);       
    }

   void getStatus()
    {
        //Debug.Log(die);
        if (die)
        {
            i += 1;
            j += 1;
            die = false;
        }
    }
}
