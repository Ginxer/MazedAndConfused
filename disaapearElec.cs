using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disaapearElec : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject m;
    //public Rigidbody rb;

    

    void Start()
    {
        gameObject.tag = "elec";
        //rb.drag = 0;
        //rb.drag = Mathf.Infinity;
        //rb.drag = Mathf.Infinity;
        //rb.drag = Mathf.Infinity;
        //rb.angularDrag = Mathf.Infinity;
    }

    // Update is called once per frame
    void Update()
    {
       int r =  Random.Range(0, 500);
        if(r == 1 && gameObject.activeInHierarchy)
        {
            gameObject.SetActive(false);
            Invoke("Reappear", 4.0f);
        }
    }
 
    void Reappear()
    {
        gameObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "player")
        {
            Debug.Log("Triggered by Enemy");
        }
    }
}
