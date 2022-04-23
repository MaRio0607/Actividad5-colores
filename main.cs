using System;
class GFG {
  //public int numElegir=0;

    readonly int V = 13;
    int[] color;
    bool sePuede(int v, int[, ] grafo, int[] color, int c)
    {
      for (int i = 0; i < V; i++)
          if (grafo[v, i] == 1 && c == color[i])
              return false;
      return true;
    }
  
    bool colorRecur(int[, ] grafo, int m, int[] color, int v)
    {
      if (v == V)
          return true;
      for (int c = 0; c <= m; c++) {
          if (sePuede(v, grafo, color, c)) {
               color[v] = c;
            if (colorRecur(grafo, m, color, v + 1))
                    return true;
              color[v] = 0;
          }
        }
        return false;
    }
 
    bool grafoColor(int[, ] grafo, int m)
    {
        color = new int[V];
        for (int i = 0; i < V; i++)
            color[i] = 0;
        if (!colorRecur(grafo, m, color, 0)) {
            Console.WriteLine("No se tiene solucion");
            return false;
        }
        mostrarSolucion(color);
        return true;
    }
 
    void mostrarSolucion(int[] color)
    {
        Console.WriteLine("Existe una solucion:" + " estos son los colores asignados");
        for (int i = 0; i < V; i++)
            Console.Write("el vertice "+  i + " es de color " + color[i] + " " +"\n");
        Console.WriteLine();
    }
 
    // Driver Code
    public static void Main(String[] args)
    {  
      // Console.WriteLine("Escriba el nodo por el cual quiere comenzar: ");
      // int num= Convert.ToInt32(Console.ReadLine());
      //numElegir=num;
      
         GFG Colorear = new GFG();
        int[, ] graph = {      /*1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12,13*/
                          /*1*/{ 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                          /*2*/{ 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 1, 1 },
                          /*3*/{ 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0 },
                          /*4*/{ 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                          /*5*/{ 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0 },
                          /*6*/{ 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1 },
                          /*7*/{ 0, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0 },
                          /*8*/{ 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                          /*9*/{ 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1 },
                         /*10*/{ 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                         /*11*/{ 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0 },
                         /*12*/{ 0, 1, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0 },
                         /*13*/{ 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0 }
                        };
                          
        int m = 3; 
        Colorear.grafoColor(graph, m);
    }
}
 
