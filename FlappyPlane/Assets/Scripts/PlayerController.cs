using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Pegando as informações do player
    // Criando as nossas variáveis
    private Rigidbody2D meuRB;

    // Velocidade
    [SerializeField] private float velocidade = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        // Pegando meu RB sozinho
        meuRB = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        // Subindo ao apertar espaço
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Fazendo a velocidade do RB ir para cima
            meuRB.velocity = Vector2.up * velocidade;
        }

        // Limitando a minha velocidade de queda
        if (meuRB.velocity.y < -velocidade)
        {
            // Travando meuRB.velocity.y em -5
            meuRB.velocity = Vector2.down * velocidade;
        }
    }
}
