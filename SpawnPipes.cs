using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{

    public GameObject pipe; //Variavel para controlar o spawn dos canos
    public float height; //Variavel para controlar a altura do spawn
    public float maxTime; //Variavel para controlar o tempo entre os spawns
    private float countTimer = 0f; //Contador de tempo
    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe); //Criando uma cópia do cano
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);// Alterando o valor do novo pipe de forma randomica
    }

    // Update is called once per frame
    void Update()
    {
        if(countTimer > maxTime){
            GameObject newPipe = Instantiate(pipe); //Criando uma cópia do cano
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 20f);//Destruir o objeto após 20 segundos na cena
            countTimer = 0;
        }

        countTimer += Time.deltaTime;
    }
}
