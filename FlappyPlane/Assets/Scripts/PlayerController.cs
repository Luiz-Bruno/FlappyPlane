using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Pegando as informações do player
    // Criando as nossas variáveis
    private Rigidbody2D meuRB;
    
    // Start is called before the first frame update
    void Start()
    {
        // Pegando meu RB sozinho
        meuRB = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
