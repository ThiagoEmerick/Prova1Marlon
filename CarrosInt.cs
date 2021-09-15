using System;
using System.Collections.Generic;

class CarrosInt : Carros{
 protected override void definirValorVeiculo(double CustoFixo){
        Valor = CustoFixo *3.0 + 0.6*CustoFixo + CustoFixo/5;
        ValorTotalCarros.add(Valor);
  } 
}