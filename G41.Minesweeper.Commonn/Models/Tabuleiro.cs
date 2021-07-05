using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Tabuleiro
    {
        public int tamanhoT { get; set; }
        public Celula[,] Grid { get; set; }
        public bool lost { get; set; }
        public bool won { get; set; }
        Random rand = new Random();
        

        public Tabuleiro(int tamanho)
        {
            this.tamanhoT = tamanho;
            lost = false;
            won = false;

            Grid = new Celula[tamanhoT, tamanhoT];

            for (int i = 0; i < tamanhoT; i++)
            {
                for (int j = 0; j < tamanhoT; j++)
                {
                    Grid[i, j] = new Celula(i, j, 0, false, false, false);
                }
            }
        }

        public void revelarCelula(int x, int y)
        {
            if(Grid[x,y].temFlag == true)
            {

            }
            else
            {
                Grid[x, y].temFlag = false;
                Grid[x, y].foiClicado = true;
                floodFill(x, y);
            }
            
        }

        public void colocarFlag(int x, int y)
        {
            if (Grid[x, y].temFlag)
                Grid[x, y].temFlag = false;
            

            else
                Grid[x, y].temFlag = true;
        }

        public bool estaSafe(int row, int column)
        {
            if (row > tamanhoT - 1 || column > tamanhoT - 1 || row < 0 || column < 0)
            {
                return false;
            }
            return true;
        }

        public void floodFill(int x, int y)
        {
            if (Grid[x, y].numVizinhosBomba != 0)
                return;

            if (estaSafe(x, y + 1))
            {
                if (!Grid[x, y + 1].temMina && !Grid[x, y + 1].foiClicado)
                {
                    Grid[x, y + 1].foiClicado = true;
                    Grid[x, y + 1].temFlag = false;
                    if (Grid[x, y + 1].numVizinhosBomba == 0)
                    {
                        floodFill(x, y + 1);
                    }
                }
            }
            if (estaSafe(x, y - 1))
            {
                if (!Grid[x, y - 1].temMina && !Grid[x, y - 1].foiClicado)
                {
                    Grid[x, y - 1].foiClicado = true;
                    Grid[x, y - 1].temFlag = false;
                    if (Grid[x, y - 1].numVizinhosBomba == 0)
                    {
                        floodFill(x, y - 1);
                    }
                }
            }
            if (estaSafe(x + 1, y))
            {
                if (!Grid[x + 1, y].temMina && !Grid[x + 1, y].foiClicado)
                {
                    Grid[x + 1, y].foiClicado = true;
                    Grid[x + 1, y].temFlag = false;
                    if (Grid[x + 1, y].numVizinhosBomba == 0)
                    {
                        floodFill(x + 1, y);
                    }
                }
            }
            if (estaSafe(x - 1, y))
            {
                if (!Grid[x - 1, y].temMina && !Grid[x - 1, y].foiClicado)
                {
                    Grid[x - 1, y].foiClicado = true;
                    Grid[x - 1, y].temFlag = false;
                    if (Grid[x - 1, y].numVizinhosBomba == 0)
                    {
                        floodFill(x - 1, y);
                    }
                }
            }
            if (estaSafe(x - 1, y - 1))
            {
                if (!Grid[x - 1, y - 1].temMina && !Grid[x - 1, y - 1].foiClicado)
                {
                    Grid[x - 1, y - 1].foiClicado = true;
                    Grid[x - 1, y - 1].temFlag = false;
                    if (Grid[x - 1, y - 1].numVizinhosBomba == 0)
                    {
                        floodFill(x - 1, y - 1);
                    }
                }
            }
            if (estaSafe(x + 1, y - 1))
            {
                if (!Grid[x + 1, y - 1].temMina && !Grid[x + 1, y - 1].foiClicado)
                {
                    Grid[x + 1, y - 1].foiClicado = true;
                    Grid[x + 1, y - 1].temFlag = false;
                    if (Grid[x + 1, y - 1].numVizinhosBomba == 0)
                    {
                        floodFill(x + 1, y - 1);
                    }
                }
            }
            if (estaSafe(x - 1, y + 1))
            {
                if (!Grid[x - 1, y + 1].temMina && !Grid[x - 1, y + 1].foiClicado)
                {
                    Grid[x - 1, y + 1].foiClicado = true;
                    Grid[x - 1, y + 1].temFlag = false;
                    if (Grid[x - 1, y + 1].numVizinhosBomba == 0)
                    {
                        floodFill(x - 1, y + 1);
                    }
                }
            }
            if (estaSafe(x + 1, y + 1))
            {
                if (!Grid[x + 1, y + 1].temMina && !Grid[x + 1, y + 1].foiClicado)
                {
                    Grid[x + 1, y + 1].foiClicado = true;
                    Grid[x + 1, y + 1].temFlag = false;
                    if (Grid[x + 1, y + 1].numVizinhosBomba == 0)
                    {
                        floodFill(x + 1, y + 1);
                    }
                }
            }

        }

        public void colocarMinas()
        {
            if (tamanhoT == 9)
            {
                int numMinas = 10;

                while (numMinas > 0)
                {
                    for (int i = 0; i < tamanhoT; i++)
                    {
                        for (int j = 0; j < tamanhoT; j++)
                        {
                            if (randNum() < 100 && !Grid[i, j].temMina && numMinas > 0)
                            {
                                Grid[i, j].temMina = true;
                                numMinas--;
                            }
                        }
                    }
                }
            }
            else if (tamanhoT == 16)
            {
                int numMinas = 40;

                while (numMinas > 0)
                {
                    for (int i = 0; i < tamanhoT; i++)
                    {
                        for (int j = 0; j < tamanhoT; j++)
                        {
                            if (randNum() < 100 && !Grid[i, j].temMina && numMinas > 0)
                            {
                                Grid[i, j].temMina = true;
                                numMinas--;
                            }
                        }
                    }
                }
            }
        }

        public void calcularVizinhosComMina()
        {
            for (int i = 0; i < tamanhoT; i++)
            {
                for (int j = 0; j < tamanhoT; j++)
                {
                    if (estaSafe(i - 1, j + 1))
                    {
                        if (Grid[i - 1, j + 1].temMina)
                        {
                            Grid[i, j].numVizinhosBomba++;
                        }
                    }
                    if (estaSafe(i, j + 1))
                    {
                        if (Grid[i, j + 1].temMina)
                        {
                            Grid[i, j].numVizinhosBomba++;
                        }
                    }
                    if (estaSafe(i + 1, j + 1))
                    {
                        if (Grid[i + 1, j + 1].temMina)
                        {
                            Grid[i, j].numVizinhosBomba++;
                        }
                    }
                    if (estaSafe(i + 1, j))
                    {
                        if (Grid[i + 1, j].temMina)
                        {
                            Grid[i, j].numVizinhosBomba++;
                        }
                    }
                    if (estaSafe(i + 1, j - 1))
                    {
                        if (Grid[i + 1, j - 1].temMina)
                        {
                            Grid[i, j].numVizinhosBomba++;
                        }
                    }
                    if (estaSafe(i, j - 1))
                    {
                        if (Grid[i, j - 1].temMina)
                        {
                            Grid[i, j].numVizinhosBomba++;
                        }
                    }
                    if (estaSafe(i - 1, j - 1))
                    {
                        if (Grid[i - 1, j - 1].temMina)
                        {
                            Grid[i, j].numVizinhosBomba++;
                        }
                    }
                    if (estaSafe(i - 1, j))
                    {
                        if (Grid[i - 1, j].temMina)
                        {
                            Grid[i, j].numVizinhosBomba++;
                        }
                    }
                }
            }
        }

        public void checkStatus()
        {
            if(tamanhoT == 9)
            {
                int clicados = 0;

                int flagsTotais = 0;

                int espacosTotais = (tamanhoT * tamanhoT) - 10; // 10 é o numero de minas

                for (int i = 0; i < tamanhoT; i++)
                {
                    for (int j = 0; j < tamanhoT; j++)
                    {
                        if (Grid[i, j].foiClicado == true && Grid[i, j].temMina == true)
                        {
                            lost = true;
                            return;
                        }
                        else if (Grid[i, j].foiClicado == true && Grid[i, j].temMina == false)
                        {
                            clicados++;
                        }else if (Grid[i,j].temFlag == true && Grid[i,j].temMina == true)
                        {
                            flagsTotais++;
                        }
                    }
                }

                if (clicados == espacosTotais)
                {
                    won = true;
                }
                if(flagsTotais == 10)
                {
                    won = true;
                }

            }else if(tamanhoT == 16)
            {
                int clicados = 0;

                int flagsTotais = 0;

                int espacosTotais = (tamanhoT * tamanhoT) - 40;

                for (int i = 0; i < tamanhoT; i++)
                {
                    for (int j = 0; j < tamanhoT; j++)
                    {
                        if (Grid[i, j].foiClicado == true && Grid[i, j].temMina == true)
                        {
                            lost = true;
                            return;
                        }
                        else if (Grid[i, j].foiClicado == true && Grid[i, j].temMina == false)
                        {
                            clicados++;
                        }else if (Grid[i, j].temFlag == true && Grid[i, j].temMina == true)
                        {
                            flagsTotais++;
                        }
                    }
                }

                if (clicados == espacosTotais)
                {
                    won = true;
                }
                if(flagsTotais == 40)
                {
                    won = true;
                }
            } 
            
        }

        public int randNum()
        {
            return rand.Next(0, 1000);
        }


    }
}

