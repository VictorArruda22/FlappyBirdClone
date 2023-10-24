using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
   public float speed = 1f;
    private Rigidbody2D rig;
    public GameObject GameOver;

    void Start(){
        rig = GetComponent<Rigidbody2D>();
    }

    void Update(){
        //Comando para identificar o clique esquerdo do mouse
        //Se quiser alterar para o botao direito, alterar para 1
        if(Input.GetMouseButtonDown(0)){
        rig.velocity = Vector2.up * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D colisor){
        GameOver.SetActive(true);//Ativa a imagem
        Time.timeScale = 0;//Pausa o jogo
    }
}
