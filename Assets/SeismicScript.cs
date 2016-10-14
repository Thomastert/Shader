using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SeismicScript : MonoBehaviour {
    private Renderer rend;
    private float FoodBar = 0.5f;
    private float ExtraFood = 0.1f;
    private float StarveAmount = -0.05f;
    private bool IsActive = false;

    void Start ()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        rend.material.SetFloat("_Amount", FoodBar);
        if (IsActive == false)
        {
            StartCoroutine(Starve());
        }
    }
        void OnCollisionEnter(Collision coll)
    {
            if (coll.gameObject.tag == "Food")
            {
                Debug.Log(coll);
            FoodBar = FoodBar + ExtraFood;
        }
        }

    IEnumerator Starve()
    {
        IsActive = true;
        yield return new WaitForSeconds(2);
        FoodBar = FoodBar + StarveAmount;
        IsActive = false;
    }
}
