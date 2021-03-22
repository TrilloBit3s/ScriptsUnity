//Mover personagem
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Controle : MonoBehaviour {
 
    // AQUI TEMOS OS PARÂMETROS QUE VÃO GERENCIAR O MOVIMENTO
    float velocidade = 30, forcaPulo = 600;
 
    // AQUI É SÓ UM ATRIBUTO DO TIPO RIGIDBODY, QUE COMEÇA VAZIO
    Rigidbody rb; 
 
    void Start(){
       // AQUI ESTAMOS VINCULANDO AQUELE ATRIBUTO ÀQUELE COMPONENTE
       // QUE ADICIONAMOS AO CUBO PELO INSPECTOR
       rb = GetComponent<Rigidbody>();
    }
 
    void Update(){
 
        // COLETANDO OS INPUTS DE UM CONTROLE ANALÓGICO
        float movimentoX = Input.GetAxis(“Horizontal”);
        float movimentoZ = Input.GetAxis(“Vertical”);
 
        // CRIANDO UM VETOR QUE TEM A DIREÇÃO DO MOVIMENTO
        Vector3 direcao = new Vector3( movimentoX, 0, movimentoZ );
 
        // AGORA APLICAMOS UMA FORÇA NESSA DIREÇÃO,
        // MULTIPLICANDO PELA VELOCIDADE
        rb.AddForce( velocidade * direcao );
 
        // E QUANDO O USUÁRIO APERTAR “F” VAMOS FAZER O CUBO PULAR
        // MOVIMENTO SÓ USA EIXOS X E Z, E PULO SÓ USA EIXO Y
        // ASSIM UM NÃO INFLUENCIA NO OUTRO
        if ( Input.GetKeyDown(KeyCode.F)){
            rb.AddForce(0, forcaPulo, 0);
        }
    }
}