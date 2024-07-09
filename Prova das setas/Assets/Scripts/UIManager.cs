using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    UIManager instance;

   [SerializeField] Sprite[] sprites = new Sprite[0];
    [SerializeField] Image[] imagens = new Image[0];
    [SerializeField] TextMeshProUGUI textoDePontuacao;
    [SerializeField] TextMeshProUGUI textoDoRelogio;
    #region Singleton
    private void Awake()
    {
        instance = this;
    }
    #endregion

    public void AtualizarSetas( KeyCode[] setas)
    {
            for(int i = 0; i < imagens.Length; i++)
             {
            if ( i <= setas.Length)
            {

            }
        
             }
            
    }
}
