﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDeSeries
{
    public class Series : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Series(int Id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = Id;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Genero = genero;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;  
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}
