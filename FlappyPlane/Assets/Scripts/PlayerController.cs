using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Pegando as informa��es do player
    // Criando as nossas vari�veis
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
