using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrthographicSize : MonoBehaviour
{
    GameObject enemy;
    GameObject player;
    CameraFollow pos;
    float objectDistance;
    float orthographicSize = 5;
    float posY = 1;
    public float smoothSpeedOrthographic;
    public float smoothSpeedPosY;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");
        player = GameObject.FindWithTag("Player");
        pos = GetComponent<CameraFollow>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (enemy.transform.position.x > player.transform.position.x)
            objectDistance = Mathf.Abs(enemy.transform.position.x - player.transform.position.x);
        else
            objectDistance = Mathf.Abs(player.transform.position.x - enemy.transform.position.x);
        
        increaseOrthographicSize();
    }

    void increaseOrthographicSize() {                 

        if (objectDistance < 16) {
            if (orthographicSize < 10) {
                orthographicSize += 1 * smoothSpeedOrthographic;
            }

            if (pos.posY < 4) {
                posY += 1 * smoothSpeedPosY;
            }
        }else {
            if (orthographicSize > 5)
                orthographicSize -= 1 * smoothSpeedOrthographic;

            if (pos.posY > 1) {
               posY -= 1 * smoothSpeedPosY;
              
            }            
        }

        GetComponent<Camera>() .orthographicSize = orthographicSize;
        pos.posY = posY;     
        
    }
}
