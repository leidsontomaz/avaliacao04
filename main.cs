using System;

class MainClass {
  public static void Main (string[] args) {

  }
  public static void Inserir {

 Console.WriteLine("---- RAKING DE MEDALHAS OLÍMPICAS ---- ");
 Console.WriteLine ("Adicione o país:");
  string nome = Console.ReadLine();
  Console.WriteLine ("Medalhas de ouro:");
  int ouro = int.Parse(Console.ReadLine());
  Console.WriteLine ("Medalhas de prata:");
  int prata = int.Parse(Console.ReadLine());
  Console.WriteLine ("Medalhas de bronze:");
  int bronze = int.Parse(Console.ReadLine());
  Pais p = new Pais(nome, ouro, prata, bronze);
  Quadromedalhas.Inserir(p);
   Array.Sort(p);
   foreach(Pais i in p) Console.WriteLine(i);
  }
}

class Pais : IComparable {
  private string nome;
  private int ouro;
  private int prata;
  private int bronze;
  public Pais(string n, int ouro, int prata, int bronze){
  this.nome = nome;
  this.ouro = ouro;
  this.prata = prata;
  this.bronze = bronze;


  }

public override string ToString(){
  return $"{nome} {ouro} {prata} {bronze}";
}

public int CompareTo(object obj){
  Pais x = (Pais) obj;
  return this.nome.CompareTo(x.nome);
}
}

class Quadromedalhas {
  private Pais[] pais = new Pais[10];
  private int np;
  public Pais []  Listar() {
    Pais[] p = new Pais[np];
    Array.Copy (cursos, p , np);
    return p;
  }
   public Pais Listar(int ouro) {
     for (int i = 0; i < np; i++)
       if (pais[i].GetOuro() == ouro) return pais[i];
     return null;
   }
   
  public void Inserir(Pais p) {
    if (np == pais.Length) {
      Array.Resize( ref cursos, 2 * pais.Length);
    
    }
    pais[np] = p;
    np++;
   }
}