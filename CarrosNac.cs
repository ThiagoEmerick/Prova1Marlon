using System;
using System.Collections.Generic;

class CarrosNac : Carros{
 protected override void definirValorVeiculo(double CustoFixo){
        Valor = CustoFixo *1.5 + 0.2*CustoFixo + CustoFixo/10;
        ValorTotalCarros.add(Valor);
  }
}