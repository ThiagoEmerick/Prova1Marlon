using System;
using System.Collections.Generic;


class Concessionaria{
  protected string localizacao{ get; set; }
  protected string GerenteP{ get; set; }
  protected int AnoFund{ get; set; }
  protected List<string> CarrosDispo = new List<string>();

  public void AdicionaCarro(Carros x){
    CarrosDispo.add(x);
  }
}