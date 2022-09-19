
namespace Library;
public class CompuertaAND
{
    public string Name { get; set; }
    public List<int> Entradas;
    public int salida { get; set; }
  
    public CompuertaAND(string name, List<int> entradas)
    {
        this.Name = name;
        this.Entradas = List<
    }

  def AgregarEntrada(self, conector, valor):
    self.entradas[conector]=valor

  def __str__(self):
    return self.nombre

  def __repr__(self):
    return self.nombre
    
  def Calcular(self):
    prod=1
    for elemento in self.entradas:
      if self.entradas[elemento]==0 or self.entradas[elemento]==1:
        prod=prod*self.entradas[elemento]
      else:
        prod=prod*self.entradas[elemento].Calcular()
    return prod
}
