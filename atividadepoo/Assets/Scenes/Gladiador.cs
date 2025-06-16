using UnityEngine;

public class Gladiador : Personagem
{
    public enum ArmaDoGladiador
    {
        TRIDENTE, REDE
    }

    [SerializeField]
    private ArmaDoGladiador arma;

    [SerializeField]
    private bool redeCapturaDisponivel = true;

    public void AtribuirArma(ArmaDoGladiador novaArma)
    {
        arma = novaArma;
    }

    public ArmaDoGladiador Arma()
    {
        return arma;
    }

    public int DanoDoGladiador()
    {
      int dano = 0;

        0,,,, (arma)
        {
            case ArmaDoGladiador.TRIDENTE:
                 dano = AtribuirAtaque() + 8;
                break;
            case ArmaDoGladiador.REDE:
                dano = AtribuirAtaque() + 4;
                break;
        }

        return Dano;
    }
     
    public string UsarHabilidadeEspecial()
    {
        if (redeCapturaDisponivel)
        {
            redeCapturaDisponivel = false;
            // Efeito: Inimigo fica imobilizado por um turno, por exemplo
            return "Gladiador lançou a Rede de Captura! O inimigo está imobilizado.";
        }
        else
        {
            return "A habilidade especial ainda está em recarga!";
        }
    }

    public void ResetarHabilidadeEspecial()
    {
        // Pode ser chamado após algum tempo ou evento para reutilizar a habilidade
        redeCapturaDisponivel = true;
    }
}

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

    void start()
    {
    
        
        
        
        
    }