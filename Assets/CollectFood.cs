using UnityEngine;
using System.Collections;

public class CollectFood : MonoBehaviour
{

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
