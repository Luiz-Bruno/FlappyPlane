using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Timer
    [SerializeField] private float timer = 1f;

    // Meu obst�culo
    [SerializeField] private GameObject obstaculo;

    // Posi��o para criar o obst�culo
    [SerializeField] private Vector3 posicao;

    // Posi��o m�nima e m�xima
    [SerializeField] private float posMin = -0.3f;
    [SerializeField] private float posMax = 2.4f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Dando oi SE timer for menor ou igual a 0
        // diminuir o valor do time por time.deltatime
        // Checar se o valor � menor ou igual a 0
        // SE a condi�o for verdadeira ent�o diga "Oi"

        timer -= Time.deltaTime;
        // timer = timer - Time.deltaTime;

        if (timer <= 0)
        {
            Debug.Log("Oi");

            // Resetando o meu timer
            timer = 1f;


            posicao.y = Random.Range(posMin, posMax);

            // Criando os meus obst�culos
            // Comando para instanciar algo
            Instantiate(obstaculo, posicao, Quaternion.identity);
        }
    }

    // Dando oi a cada 1 segundo
}
