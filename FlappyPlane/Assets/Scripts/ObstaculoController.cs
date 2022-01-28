using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{

    // Variável dfe velocidade
    [SerializeField] private float velocidade = 4f;

    [SerializeField] private GameObject eu;

    // Criando a variável do game controller
    [SerializeField] private GameController game;


    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(eu, 5f);

        // Encontrando o game controller da cena atual
        game = FindObjectOfType<GameController>();

       
    }

    // Update is called once per frame
    void Update()
    {
        // Indo para a esquerda
        //transform.position = transform.position + Vector3.left;
        transform.position += Vector3.left * Time.deltaTime * velocidade;

        // A minha velocidade vai ser 4f + level
        velocidade = 4f + game.RetornaLevel();
    }
}
