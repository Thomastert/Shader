using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    private float speed = 5f;

	
	void Start ()
    {

	}

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        x *= speed * Time.deltaTime;
        y *= speed * Time.deltaTime;

        transform.Translate(x,0,y);

        
    }
}
