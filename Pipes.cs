using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed;
    public float test;
    // Update is called once per frame
    //Criando código para mover os pipes
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

}
