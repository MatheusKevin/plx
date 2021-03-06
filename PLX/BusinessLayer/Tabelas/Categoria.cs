﻿using DataLayer.Tabelas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Tabelas
{
    internal class Categoria : Base
    {
        
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public virtual List<Anuncio> Anuncios { get; set; }
        public virtual List<Categoria> Categorias { get; set; }
    }
}
