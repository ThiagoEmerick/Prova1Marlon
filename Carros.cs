using System;
using System.Collections.Generic;


class Carros{

  protected string Cor{ get; set; }
  protected string Marca{ get; set; }
  protected string Modelo{ get; set; }
  protected int ano{ get; set; }
  protected double Valor{ get; set; }
  protected List<double> ValorTotalCarros = new List<double>();


  protected virtual void definirValorVeiculo(double Custofixo){
    
  }

   public void CalcPortifolio(){
     double CalcularPortfolio = 0;

    for (int x=0;x < ValorTotalCarros.Count; x++){
      CalcularPortfolio += ValorTotalCarros[x];
    }
  }
}