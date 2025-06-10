using UnityEngine;
using UnityEngine.Serialization;

public class Personagem : MonoBehaviour

{
    [ SerializeField ]
    public string Nome;
    [ SerializeField ]
    public string Nivel;
    [ SerializeField ]
    public string Ataque;
    [ SerializeField ]
    public string Defesa;

    public void AtribuirNome(string nome)
    {
        this.Nome = nome;
    }
    
    public string getNome()
    {
        return this.Nome;
    }

    public void AtribuirNivel(string nivel)
    {
        this.Nivel = nivel;
    }
    
    public string getNivel()
    {
        return this.Nivel;
    }

    public void AtribuirAtaque(string ataque)
    {
        this.Ataque = ataque;
    }

    public string getAtaque()
    {
        return this.Ataque;
    }
    
    public void AtribuirDefesa(string defesa)
    {
        this.Defesa = defesa;
    }

    public string getDefesa()
    {
        return this.Defesa;
    }
    
    
    
    
    
    
    

  

   