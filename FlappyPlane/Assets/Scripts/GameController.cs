using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Timer
    [SerializeField] private float timer = 1f;

    // Meu obstáculo
    [SerializeField] private GameObject obstaculo;

    // Posição para criar o obstáculo
    [SerializeField] private Vector3 posicao;

    // Posição mínima e máxima
    [SerializeField] private float posMin = -0.3f;
    [SerializeField] private float posMax = 2.4f;

    // Tempo mínimo e máximo
    [SerializeField] private float tMin = 1f;
    [SerializeField] private float tMAx = 3f;

    // Variável dos pontos
    private float pontos = 0f;

    // Variável dos pontos do canvas
    [SerializeField] private Text pontosTexto;

    // Variável do level
    private int level = 1;

    // Variável para ganhar level
    [SerializeField] private float proximoLevel = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Dando oi SE timer for menor ou igual a 0
        // diminuir o valor do time por time.deltatime
        // Checar se o valor é menor ou igual a 0
        // SE a condião for verdadeira então diga "Oi"

        // Ganhando pontos
        Pontos();



        // Refatore este código e chame de CriaObstáculo
        CriaObstaculo();

        // Ganhando level
        GanhaLevel();
    }

        // Criando o método para lidar com os pontos
    private void Pontos()
    {
        pontos += Time.deltaTime;

        // Passando os meus pontos para o texto dos pontos
        pontosTexto.text = Mathf.Round(pontos).ToString();

    }

    // Ganhando level
    private void GanhaLevel()
    {
        // Mostando o level
        Debug.Log(level);
        // SE os pontos forem maiores do que próximo level, então eu aumento o valor do level
        // Eu dobro a quantidade de pontos para o próximo level
        if (pontos > proximoLevel)
        {
            // Aumentando o level em 1
            level++;
            // Dobrando o valor do próximo level
            proximoLevel = proximoLevel * 2; // proximoLevel *= 2;
        }
    }

    private void CriaObstaculo()
    {
        timer -= Time.deltaTime;
        // timer = timer - Time.deltaTime;

        if (timer <= 0)
        {
            

            // Resetando o meu timer
            // Timer vai ficar com um valor aleatório entre 1f e 3f
            timer = Random.Range(tMin, tMAx);



            posicao.y = Random.Range(posMin, posMax);

            // Criando os meus obstáculos
            // Comando para instanciar algo
            Instantiate(obstaculo, posicao, Quaternion.identity);
        }
    }

    
}
