using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public static gamemanager Instance = null;
    public int Score;
    public string name = "air";
    public GameObject CanVas;
    public float speed = 10;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        CanVas = GameObject.FindGameObjectWithTag("CanVas");

    }


    public void SetCanvase(bool active)
    {
        CanVas.SetActive(active);
    }

    void MoveR()
    {
        transform.position = new Vector3(0, 0, 0);

    }

    void MoveI()
    { 
        
    }

    private void Update()
    {
        GetComponent<BoxCollider>();
        if (Input.GetKey(KeyCode.R))
        {
            MoveR();
        }

   
        if (Input.GetKey(KeyCode.I))
        {
            MoveI();
        }

  

       
    }


}
