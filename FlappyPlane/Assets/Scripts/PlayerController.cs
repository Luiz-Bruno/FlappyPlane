using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Pegando as informa��es do player
    // Criando as nossas vari�veis
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
        // Subindo ao apertar espa�o
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
