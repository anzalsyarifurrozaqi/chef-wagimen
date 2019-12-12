using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sample1 : MonoBehaviour
{
    public Vector2 jumpForce = new Vector2(0,300);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int x = 0;
		int y = 0;
		int z = 0;
        if(Input.GetKey(KeyCode.A)){
			GetComponent<SpriteRenderer>().flipX = false;
			x = -4;
			// transform.position = transform.position + (kekiri * speed * Time.deltaTime);
		}
        if(Input.GetKey(KeyCode.D)){
			GetComponent<SpriteRenderer>().flipX = true;
			x = 4;
			// transform.position = transform.position + (kekanan * speed * Time.deltaTime);
		}

        if(Input.GetKeyDown(KeyCode.W)){
			GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
			GetComponent<Rigidbody2D> ().AddForce(jumpForce);
		}
        transform.position += new Vector3(x,y,z) * Time.deltaTime;
    }
}
