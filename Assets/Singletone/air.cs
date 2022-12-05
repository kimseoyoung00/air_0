using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class air : MonoBehaviour
{
    public string name = "air";
    public Color c = new Color(255, 255, 255);
    public float speed = 10;
    RaycastHit hitData;
    public RaycastHit[] hits;
 



    void Start()
    {
        //  if (GetComponent<Rigidbody>() == null)
        //  {
        //      gameObject.AddComponent<Rigidbody>();
        //  }
        //   GetComponent<BoxCollider>().isTrigger = true;
        //  GetComponent<BoxCollider>().size = new Vector3(3, 3, 3);
        //InvokeRepeating(MoveDown, 2f, 2f)
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        transform.position += new Vector3(h, 0, v);
        transform.position += new Vector3(h, 0, v) * 0.01f;




        MoveFront();

        GetComponent<BoxCollider>();
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveFront();
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveUP();

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();

        }


        if (Input.GetKey(KeyCode.LeftAlt))
        {
            MoveDown();
        }

        if (Input.GetKey(KeyCode.RightAlt))
        {
            MoveRightFront();
        }

        if (Input.GetKey(KeyCode.RightShift))
        {
            MoveLifFront();

        }


        if (Input.GetKey(KeyCode.I))
        {
            gamemanager.Instance.SetCanvase(false);

        }

        if (Input.GetKey(KeyCode.Q))
        {
            MoveRightRound();

        }

    }

 



    public void MoveFront()
    {
        transform.position = transform.position + new Vector3(0, 0, 1);

       // int x = 10;
     //   x = x + 10;
      //  x += 10;
    }

    public void MoveRightRound()
    {
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, -5, 0);

    }


    public void MoveRight()
    {
        transform.position = transform.position + new Vector3(30, 0, 0);

    }

    public void MoveLeft()
    {
        transform.position = transform.position + new Vector3(-30, 0, 0);
    }

    public void MoveUP()
    {
        transform.position = transform.position + new Vector3(0, 1, 0);

    }

    public void MoveDown()
    {
        transform.position = transform.position + new Vector3(0, -5, 0);
      //  Invoke(air, 3f);


        //Invoke("pullup", 1f);

    }

    public void MoveRightFront()
    {
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, 37);

    }


    public void MoveLifFront()
    {
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, -31);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("wall"))
        {            
           
            Destroy(gameObject);
        }
    }
}
