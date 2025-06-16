using UnityEngine;
using UnityEngine.Serialization;

public class Personagem : MonoBehaviour

{
    [SerializeField] public string Nome;
    [SerializeField] public int Dano;
    [SerializeField] public int Ataque;
    [SerializeField] public string Defesa;

    public void AtribuirNome(string nome)
    {
        this.Nome = nome;
    }

    public string getNome()
    {
        return this.Nome;
    }

    public void AtribuirNivel(string dano)
    {

        this.Dano = dano;
    }

    public string getNivel()
    {
        return this.Dano;
    }

    public void AtribuirAtaque(int ataque)
    {
        this.Ataque = Ataque;
    }

    public int AtribuirAtaque;() => this.Ataque

    public void AtribuirDefesa(string defesa)
    {
        this.Defesa = defesa;
    }

    public string getDefesa()
    {
        return this.Defesa;
    }

}

internal class Ataque
{
}
    
    
    
    
    

  

   