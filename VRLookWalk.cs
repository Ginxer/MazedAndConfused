using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour
{
    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float speed = 50.0f;
    public bool moveForward;
    //float counter;
    //public float stun = 2.0f

    private CharacterController cc;
    Vector3 original;


    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
        gameObject.tag = "Player";
        original = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }

        if (moveForward )
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
        }
    }

    /*
    void OnCollisionEnter(Collider other)
    {
      if(other.gameObject.tag == "end")
      {
          gameObject.transform.position = original;
      }
    }

    */

    public IEnumerator Wait(float stun)
    {
        yield return new WaitForSeconds(stun);
    }

    /*
    void OnCollisionEnter(Collision col)
    {
        print(col.gameObject.tag);
        Debug.Log(col.gameObject.tag);
        if(col.gameObject.tag == "elec" )
        {
            //print(col.gameObject.tag)
            Debug.Log("eeee");
            speed = 0.0f;
            Wait(2.0f);
            //speed = 50.0f;
        }

    }
    */
    void revertSpeed ()
     {
        speed = 50.0f;
     }

    /*
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("elec"))
        {
            speed = 0.0f;
            ///stun = 2.0f;
           // other.gameObject.SetActive(false);
            speedy();
            //speedy();
            revertSpeed();
            //revertSpeed();
        }  
    }

    IEnumerator speedy()
    {
        
        yield return new WaitForSeconds(2.0f);
        print("ok");
        //WaitForSeconds(stun);
        revertSpeed();
    }
    */
}
