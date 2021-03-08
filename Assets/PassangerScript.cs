using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassangerScript : MonoBehaviour
{
    public GameObject dropOff;
    public Transform[] dropOffPlace;
    public bool passanger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Passanger")
        {
            int drop = Random.Range(0, 9);
            Destroy(col.gameObject);
            Instantiate(dropOff, dropOffPlace[drop]);
            float fee = Vector2.Distance(this.transform.position, dropOffPlace[drop].position);
            Debug.Log(fee);
        }
    }
}
