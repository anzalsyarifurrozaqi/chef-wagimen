using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public static EnemyGenerator instantiate;
    public GameObject[] enemys;
    GameObject player;
    float[] objectsDistance;
    public float distance;
    public bool die = false;
    public int i;
    int j = 0;
    int enemyLenght;
    // Start is called before the first frame update
    void Start()
    {
        if (instantiate == null)
        {
            instantiate = this;
        }
        enemys = GameObject.FindGameObjectsWithTag("Enemy");
        player = GameObject.FindWithTag("Player");        
        objectsDistance = new float[enemys.Length];
        enemyLenght = enemys.Length - 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        //Debug.Log("i " + i);
        //Debug.Log("j " + j);
        //Debug.Log(enemys[i].transform.position.x);
        getStatus();
        Debug.Log(enemyLenght);        
        i = 0;
        for (int temp = 0; temp < enemys.Length; temp++)
        {            
            if (enemys[temp] != null)
            {
                if (enemys[i] == null)
                {
                    i = temp;
                }
                if (enemys[i].transform.position.x > enemys[temp].transform.position.x)
                {
                    i = temp;
                }                
            }            
        }        
        Debug.Log("i" + i);
        if (enemys[i] != null)
        {
            if (player.transform.position.x < enemys[i].transform.position.x)
            {
                objectsDistance[j] = Mathf.Abs(enemys[i].transform.position.x - player.transform.position.x);
            }
            else
            {
                objectsDistance[j] = Mathf.Abs(player.transform.position.x - enemys[i].transform.position.x);
            }
            
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
        //Debug.Log(enemys.Length);
        if (die)
        {            
            j += 1;
            die = false;
        }
    }
}
