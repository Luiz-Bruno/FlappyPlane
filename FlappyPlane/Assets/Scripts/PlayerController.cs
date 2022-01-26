using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        Subir();

        LimitandoVelocidade();
    }

    private void LimitandoVelocidade()
    {
        // Limitando a minha velocidade de queda
        if (meuRB.velocity.y < -velocidade)
        {
            // Travando meuRB.velocity.y em -5
            meuRB.velocity = Vector2.down * velocidade;
        }
    }

    // Criando o método subir
    public void Subir()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Fazendo a velocidade do RB ir para cima
            meuRB.velocity = Vector2.up * velocidade;
        }
    }

    // Configurando a colisão do player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bati!");

        //Usando o Scenemanager, eu preciso dar load na cena "Jogo"
        SceneManager.LoadScene("Jogo");
    }
}
