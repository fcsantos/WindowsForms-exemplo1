﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidade
{
    public class Editora
    {
        public virtual int IdEditora { get; set; }
        public virtual string Nome { get; set; }

        #region Relacionamentos
        //public virtual ICollection<Livro> Livros { get; set; }
        #endregion
    }
}
