using System;
using System.Collections.Generic;
using System.Text;

namespace atividade_4___POO
{
    class Jogador
    {
        private string nome;
        private int idade;
        private int habilidade;
        private int camisa;
        private int gols;


        public Jogador(string xnome, int xidade, int xhabilidade, int xcamisa)
        {
            this.nome = xnome;
            this.idade = xidade;
            this.habilidade = xhabilidade;
            this.camisa = xcamisa;
        }

        public string getNome()
        {
            return nome;
        }

        public int getCamisa()
        {
            return camisa;
        }

        public int getHabilidade()
        {
            return habilidade;
        }

        public int Gols
        {
          get { return gols; }
          set { gols += value; }
        }

        public string getDescricao()
        {
            return "Nome: " + this.getNome() +
                    "\tIdade: " + this.idade +
                    "\tHabilidade: " + this.getHabilidade() +
                    "\tCamisa : " + this.getCamisa() +
                    "\tGols: " + this.Gols;
        }

        
    }
}
