//Script Move movimenta o jogador para frente e para trás 
//Script Jump faz o personagem pular 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    private Rigidbody2D rig;
    
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        Vector3 moviment = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f); //eixos 0y e 0Z movimentação lateral
        transform.position += moviment * Time.deltaTime * Speed; //adiciona velocidade
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
        }
    }
}