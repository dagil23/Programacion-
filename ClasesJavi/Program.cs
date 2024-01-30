Compas compas = new Compas();
Circulo circulo = compas.DibujaCirculo(3.5f);
Rotulador rotulador = Estuche.GetRotuladores()
                      [
                          new Random().Next(0, Estuche.NUMERO_ROTULADORES)
                      ];
rotulador.Rotula(circulo.Perimetro());
Pincel pincel = new Pincel();
pincel.SetColor(Color.Verde);
pincel.Pinta(circulo.Area());   