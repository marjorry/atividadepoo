using UnityEngine;
using UnityEngine.Serialization;

public class Personagem : MonoBehaviour

{
    [ SerializeField ]
    public string nome;
    [ SerializeField ]
    public int Nivel;
    [ SerializeField ]
    public int vidaMaxima;
    [ SerializeField ]
    public int vidaAtual;
    [ SerializeField ]
    public int ataque;
    [ SerializeField ]
    public int defesa;

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }
    
    public string getNome()
    {
        return this.nome;
    }

    public void AtribuirNivel(int nivel)
    {
        this.Nivel = nivel;
    }
    
    public string getNivel()
    {
        return this.Nivel;
    }
    
    
    
    
    
    
    
    

    [ SerializeField ]

   