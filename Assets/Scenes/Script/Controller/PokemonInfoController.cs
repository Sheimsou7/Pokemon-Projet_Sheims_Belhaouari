using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class Pokemon_Info_Controller : MonoBehaviour
{
    [SerializeField] private Text txtName;
    [SerializeField] private Text txtCaption;
    [SerializeField] private Text txtSize;
    [SerializeField] private Text txtWeight;
    [SerializeField] private Image imgIcon;
    [SerializeField] private Text txtType;

    public int idPoke;
    public DataBaseManager databaseManager;

    private void Awake()
    {
       
      databaseManager = FindAnyObjectByType<DataBaseManager>();
    }

    private void Start()
    {
        RefreshUI(databaseManager.GetData(idPoke));
    }


    private void RefreshUI(PokemonData data)
    {
        PokemonData pokemonData = databaseManager.GetData(idPoke);
        
        imgIcon.sprite = pokemonData.icon; ;
        txtName.text = $"Name: {pokemonData.name}";
        txtSize.text = $"Taille : {pokemonData.size.ToString()}";
        txtWeight.text = $"Poids: {pokemonData.weight.ToString()}";
        txtCaption.text = $"Description: \n" +pokemonData.caption;
        txtType.text = $"Type: {pokemonData.type}";
    }

}